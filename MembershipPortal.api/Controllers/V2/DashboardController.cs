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
        private readonly IGTINRequestSvc _gtinRequestSvc;
        private readonly IGTINInformationSvc _gtinInformationSvc;
        private readonly IImageBankSvc _imagebankSvc;
        private readonly IImageRequestSvc _imageRequestSvc;
        private readonly IStatisticsService _statisticsSvc;

        public DashboardController(IGTINRequestSvc gtinRequestSvc, IGTINInformationSvc gtinInformationSvc, IImageBankSvc imagebankSvc, 
            IImageRequestSvc imageRequestSvc, IStatisticsService statisticsSvc, IMapper mapper, IOptions<RegistrationAPI_Settings> registrationAPI)
        {
            this._mapper = mapper;
            this._registrationAPI = registrationAPI.Value;
            this._gtinRequestSvc = gtinRequestSvc;
            this._gtinInformationSvc = gtinInformationSvc;
            this._imagebankSvc = imagebankSvc;
            this._imageRequestSvc = imageRequestSvc;
            this._statisticsSvc = statisticsSvc;
        }
        // GET: api/<BenefitDashboardController>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RDashboard.Get)]
        public async Task<IActionResult> Get(string registrationid)
        {
            DashboardVM model = new DashboardVM();
            //var tokenValidation = Request.Headers["Authorization"].SingleOrDefault();
            //string baseURL = this._registrationAPI.BaseUrl;
            //string imageRequestEndPoint = "api/v2/imagerequest/getbyregistrationid/";

            //var token = !string.IsNullOrEmpty(tokenValidation) ? tokenValidation.Split(" ").Last() : null;
            //ExternalCallModels imageRequestModel = new ExternalCallModels()
            //{
            //    baseURL = baseURL,
            //    endpoint = imageRequestEndPoint,
            //    Token = token
            //};
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

                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        //[AllowAnonymous]
        //[HttpGet(ApiRoutes.RDashboard.GetActive)]
        //public async Task<IActionResult> GetAllActive([FromQuery] RecordPaginationModel pagination)
        //{
        //    try
        //    {
        //        int skip = (pagination.PageNumber - 1) * pagination.PageSize;
        //        int take = pagination.PageSize;
        //        var obj = await _service.GetAllActive(skip, take);
        //        if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
        //        {
        //            var result = _mapper.Map<IEnumerable<DashboardVM>>(obj.ReturnedObject);
        //            return Ok(result);
        //        }

        //        return NotFound();
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
        //    }
        //}

        //[AllowAnonymous]
        //[HttpGet(ApiRoutes.RDashboard.GetByID)]
        //public async Task<IActionResult> GetByID(int id)
        //{
        //    try
        //    {
        //        var obj = await _service.GetByID(id);

        //        if (obj.IsSuccess && obj.ReturnedObject != null)
        //        {
        //            var result = _mapper.Map<DashboardVM>(obj.ReturnedObject);
        //            return Ok(result);
        //        }

        //        return NotFound();
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
        //    }
        //}

        //[AllowAnonymous]
        //[HttpGet(ApiRoutes.RDashboard.GetByRegID)]
        //public async Task<IActionResult> GetByRegID(string registrationid)
        //{
        //    try
        //    {
        //        var obj = await _service.GetByRegistrationID(registrationid);

        //        if (obj.IsSuccess && obj.ReturnedObject != null)
        //        {
        //            var result = _mapper.Map<IEnumerable<DashboardVM>>(obj.ReturnedObject);
        //            return Ok(result);
        //        }

        //        return NotFound(null);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
        //    }
        //}

        //[AllowAnonymous]
        //[HttpPost(ApiRoutes.RDashboard.Create)]
        //public async Task<IActionResult> Post([FromBody] DashboardVM_Create req)
        //{
        //    ServiceResponse<DashboardVM> response = new ServiceResponse<DashboardVM>
        //    {
        //        ReturnedObject = null,
        //        IsSuccess = false,
        //        Message = string.Empty
        //    };
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            var errors = string.Join("; ", ModelState.Values
        //                                .SelectMany(x => x.Errors)
        //                                .Select(x => x.ErrorMessage));
        //            response.Message = errors;
        //            return StatusCode(StatusCodes.Status400BadRequest, response);
        //        }

        //        Dashboard model = _mapper.Map<Dashboard>(req);
        //        var obj = await _service.Save(model);
        //        response = _mapper.Map<ServiceResponse<DashboardVM>>(obj);
        //        if (response.IsSuccess)
        //        {
        //            return StatusCode(StatusCodes.Status201Created, response);
        //        }
        //        return StatusCode(StatusCodes.Status400BadRequest, response);
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Message = ex.Message;
        //        return StatusCode(StatusCodes.Status403Forbidden, response);
        //    }

        //}

        //[AllowAnonymous]
        //[HttpPut(ApiRoutes.RDashboard.Update)]
        //public async Task<IActionResult> UpdateDashboard([FromBody] DashboardVM_Update req)
        //{
        //    ServiceResponseVM<DashboardVM> response = new ServiceResponseVM<DashboardVM>
        //    {
        //        ReturnedObject = null,
        //        IsSuccess = false,
        //        Message = string.Empty
        //    };
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            var errors = string.Join("; ", ModelState.Values
        //                                .SelectMany(x => x.Errors)
        //                                .Select(x => x.ErrorMessage));
        //            response.Message = errors;
        //            return StatusCode(StatusCodes.Status400BadRequest, response);
        //        }
        //        var newObj = await _service.GetByID(req.id);
        //        if (newObj.IsSuccess && newObj.ReturnedObject != null)
        //        {
        //            if (newObj.ReturnedObject.brandname != req.brandname)
        //            {
        //                var obj = _mapper.Map<Dashboard>(req);
        //                var isExist = await _service.IsExist(obj);
        //                if (isExist.IsSuccess && isExist.ReturnedObject)
        //                {
        //                    response.Message = "Brand Name exist in storage.";
        //                    return StatusCode(StatusCodes.Status302Found, response);
        //                }
        //            }
        //            newObj.ReturnedObject.brandname = req.brandname;
        //            var result = await _service.Save(newObj.ReturnedObject);
        //            response = _mapper.Map<ServiceResponseVM<DashboardVM>>(result);
        //            if (response.IsSuccess)
        //            {
        //                return StatusCode(StatusCodes.Status200OK, response);
        //            }
        //            return StatusCode(StatusCodes.Status304NotModified, response);
        //        }
        //        response.Message = "Brand Information cannot be found.";
        //        return StatusCode(StatusCodes.Status404NotFound, response);
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Message = ex.Message;
        //        return StatusCode(StatusCodes.Status400BadRequest, response);
        //    }
        //}

        //[AllowAnonymous]
        //[HttpPut(ApiRoutes.RDashboard.ChangeStatus)]
        //public async Task<IActionResult> ChangeActivationStatus([FromQuery] DashboardVM_ActivationStatus model)
        //{
        //    ServiceResponseVM<DashboardVM> response = new ServiceResponseVM<DashboardVM>
        //    {
        //        ReturnedObject = null,
        //        IsSuccess = false,
        //        Message = string.Empty
        //    };
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            var errors = string.Join("; ", ModelState.Values
        //                                .SelectMany(x => x.Errors)
        //                                .Select(x => x.ErrorMessage));
        //            response.Message = errors;
        //            return StatusCode(StatusCodes.Status400BadRequest, response);
        //        }

        //        var newObj = await _service.GetByID(model.id);
        //        if (newObj.IsSuccess && newObj.ReturnedObject != null)
        //        {
        //            newObj.ReturnedObject.isActive = model.isActive;
        //            var result = await _service.Save(newObj.ReturnedObject);
        //            response = _mapper.Map<ServiceResponseVM<DashboardVM>>(result);
        //            if (response.IsSuccess)
        //            {
        //                return StatusCode(StatusCodes.Status200OK, response);
        //            }
        //            return StatusCode(StatusCodes.Status304NotModified, response);
        //        }
        //        response.Message = "Brand Information cannot be found.";
        //        return StatusCode(StatusCodes.Status404NotFound, response);
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Message = ex.Message;
        //        return StatusCode(StatusCodes.Status400BadRequest, response);
        //    }
        //}
    }
}
