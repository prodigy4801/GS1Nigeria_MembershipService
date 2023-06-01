using AutoMapper;
using MembershipPortal.viewmodels;
using MembershipPortal.api.Contract.V2;
using MembershipPortal.data;
using MembershipPortal.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembershipPortal.api.Authorization;
using MembershipPortal.api.Models;
using MembershipPortal.service.Concrete.ExternalEntries;
using Microsoft.Extensions.Options;
using MembershipPortal.data.ExternalEntries;

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly RegistrationAPI_Settings _registrationAPI;
        private readonly IGTINFeeSvc _gtinFeeSvc;
        private readonly IGTINRequestSvc _gtinRequestSvc;
        private readonly IGTINInformationSvc _gtinInformationSvc;
        private readonly IImageBankSvc _imagebankSvc;
        private readonly IImageRequestSvc _imageRequestSvc;
        private readonly IStatisticsService _statisticsSvc;

        public DashboardController(IGTINRequestSvc gtinRequestSvc, IGTINInformationSvc gtinInformationSvc, IImageBankSvc imagebankSvc, 
            IImageRequestSvc imageRequestSvc, IStatisticsService statisticsSvc, IMapper mapper, IOptions<RegistrationAPI_Settings> registrationAPI,
            IGTINFeeSvc gtinFeeSvc)
        {
            this._mapper = mapper;
            this._registrationAPI = registrationAPI.Value;
            this._gtinRequestSvc = gtinRequestSvc;
            this._gtinInformationSvc = gtinInformationSvc;
            this._imagebankSvc = imagebankSvc;
            this._imageRequestSvc = imageRequestSvc;
            this._statisticsSvc = statisticsSvc;
            this._gtinFeeSvc = gtinFeeSvc;
        }
        // GET: api/<BenefitDashboardController>
        //[AllowAnonymous]
        [HttpGet(ApiRoutes.RDashboard.Get)]
        public async Task<IActionResult> Get(string registrationid)
        {
            ServiceResponse<DashboardVM> response = new ServiceResponse<DashboardVM>
            {
                ReturnedObject = null,
                IsSuccess = true,
                Message = string.Empty
            };
            DashboardVM model = new DashboardVM();

            try
            {
                var gtinRequestObj = await _gtinRequestSvc.GetListByRegistrationID(registrationid);
                if (gtinRequestObj.IsSuccess && gtinRequestObj.ReturnedObject.Count() > 0)
                {
                    model.PendingGCPStatus = gtinRequestObj.ReturnedObject.Where(x => !x.isgcpassigned).Any();
                    model.TotalGtinsRequested = gtinRequestObj.ReturnedObject.Where(x => x.isapproved && x.isgcpassigned).Select(x => x.gtincount).Sum();
                }

                var gtinInformationObj = await _gtinInformationSvc.CountListedGtinByRegID(registrationid);
                if (gtinInformationObj.IsSuccess)
                {
                    model.UsedGtins = model.TotalGtinsRequested > 0 ? gtinInformationObj.ReturnedObject : 0;
                }
                model.RemainingGtins =  model.TotalGtinsRequested - model.UsedGtins;

                var imageRequestObj = await _imageRequestSvc.GetListByRegistrationID(registrationid);
                if(imageRequestObj.IsSuccess && imageRequestObj.ReturnedObject.Count() > 0)
                {
                    model.PendingImageRequest = imageRequestObj.ReturnedObject.Where(x => !x.isapproved).Any();
                    model.TotalImagesRequested = imageRequestObj.ReturnedObject.Where(x => x.isapproved).Select(x => x.imagecount).Sum();
                }

                var imageBankObj = await _imagebankSvc.GetByRegistrationID(registrationid);
                if(imageBankObj.IsSuccess && imageBankObj.ReturnedObject != null)
                {
                    model.RemainingImages = imageBankObj.ReturnedObject.imageReserve;
                }
                model.UsedImages = model.TotalImagesRequested - model.RemainingImages;

                var accumulatedRenewalObj = await _statisticsSvc.RenewalAccumulation(registrationid);
                if(accumulatedRenewalObj.IsSuccess && accumulatedRenewalObj.ReturnedObject != null)
                {
                    model.NextPaymentDate = accumulatedRenewalObj.ReturnedObject.AccumulatedInfo.Select(x => x.RenewalYear).Last();
                    model.NextRenewalAmount = accumulatedRenewalObj.ReturnedObject.AccumulatedInfo.Select(x => x.Amount).Sum();
                }
                response.ReturnedObject = model;
                return StatusCode(StatusCodes.Status200OK, response);
                //return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        
    }
}
