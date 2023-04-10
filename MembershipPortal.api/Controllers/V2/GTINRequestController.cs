using AutoMapper;
using MembershipPortal.viewmodels;
using MembershipPortal.api.Contract.V2;
using MembershipPortal.data.ExternalEntries;
using MembershipPortal.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembershipPortal.api.Authorization;
using Microsoft.Extensions.Options;
using MembershipPortal.api.Models;
//using MembershipPortal.data.ExternalEntries.Models;
using MembershipPortal.data;
using MembershipPortal.api.Helpers;

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("")]
    [ApiController]
    public class GTINRequestController : ControllerBase
    {
        private readonly IGTINRequestSvc _service;
        private readonly IGCPInformationSvc _gcpInformationService;
        private readonly IGTINFeeSvc _gtinfeeService;
        private readonly IMapper _mapper;
        private readonly ILogger<GTINRequestController> _logger;
        private readonly RegistrationAPI_Settings _registrationAPI;

        public GTINRequestController(IGTINRequestSvc service, IGTINFeeSvc gtinfeeService, IGCPInformationSvc gcpInformationService, IMapper mapper, ILogger<GTINRequestController> logger, IOptions<RegistrationAPI_Settings> registrationAPI)
        {
            this._service = service;
            this._gtinfeeService = gtinfeeService;
            this._gcpInformationService = gcpInformationService;
            this._mapper = mapper;
            this._logger = logger;
            this._registrationAPI = registrationAPI.Value;
        }

        //[AllowAnonymous]
        [HttpPost(ExternalApiRoutes.RGTINRequest.AdditionalRequest)]
        public async Task<IActionResult> AdditionalRequest([FromBody] GTINRequestVM_Create req)
        {
            if (!ModelState.IsValid)
            {
                var errors = string.Join("; ", ModelState.Values
                                    .SelectMany(x => x.Errors)
                                    .Select(x => x.ErrorMessage));
                return StatusCode(StatusCodes.Status400BadRequest, new ServiceResponse<object> { IsSuccess = false, Message = errors, ReturnedObject = null });
            }
            var model = _mapper.Map<GTINRequest>(req);
            var gtinRequestResponse = await _service.Save(model, req.imagerequestcount);
            var response = _mapper.Map<ServiceResponse<GTINRequest>>(gtinRequestResponse);

            return Ok(response);
        }
    }
}
