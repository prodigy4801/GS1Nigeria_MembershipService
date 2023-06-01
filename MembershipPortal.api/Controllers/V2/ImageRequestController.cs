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
using MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend;

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("")]
    [ApiController]
    public class ImageRequestController : ControllerBase
    {
        private readonly IImageRequestSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<ITFInformationController> _logger;

        public ImageRequestController(IImageRequestSvc service, IMapper mapper, ILogger<ITFInformationController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }

        // GET api/<BenefitController>/5
        [HttpGet(ApiRoutes.RImageRequest.GetByRegistrationID)]
        public async Task<IActionResult> GetByRegID(string registrationid)
        {
            ServiceResponseList<ImageRequestVM> response = new ServiceResponseList<ImageRequestVM>
            {
                ReturnedObject = new List<ImageRequestVM>(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetListByRegistrationID(registrationid);
            response = _mapper.Map<ServiceResponseList<ImageRequestVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        // POST api/<BenefitITFInformationController>
        [HttpPost(ApiRoutes.RImageRequest.CreateImageGTIN)]
        public async Task<IActionResult> Post([FromBody] ImageRequestVM_request req)
        {
            ServiceResponse<ImageRequestVM> response = new ServiceResponse<ImageRequestVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                    response.Message = errors;
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }
                if(req.imagecount < 5)
                {
                    response.Message = "Image Request failed to process as the requested Image count is below 5.";
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }

                var obj = await _service.SaveImage(req.registrationid, req.imagecount, "GTIN");
                response = _mapper.Map<ServiceResponse<ImageRequestVM>>(obj);
                if (response.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, response);
                }
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return StatusCode(StatusCodes.Status403Forbidden, response);
            }
        }
    }
}
