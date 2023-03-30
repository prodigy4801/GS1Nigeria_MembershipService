using AutoMapper;
using MembershipPortal.api.Authorization;
using MembershipPortal.api.Contract.V2;
using MembershipPortal.api.Helpers;
using MembershipPortal.api.Helpers.RegistrationAPIService;
using MembershipPortal.api.Helpers.RegistrationAPIService.Request;
using MembershipPortal.api.Helpers.RegistrationAPIService.Response;
using MembershipPortal.api.Models;
using MembershipPortal.service;
using MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend;
using MembershipPortal.viewmodels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCryptNet = BCrypt.Net.BCrypt;

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticationSvc _service;
        private readonly IMapper _mapper;
        private readonly RegistrationAPI_Settings _registrationAPI;
        private readonly IImageBankSvc _imagebankSvc;
        private readonly IGTINInformationSvc _gtininformationSvc;
        private readonly IGCPInformationSvc _gcpinformationSvc;
        //private IJwtUtils _jwtUtils;
        //private readonly AppSettings _appSettings;
        //private readonly ILogger<AuthenticationController> _logger;

        //public AuthenticationController(IJwtUtils jwtUtils, IAPICredentialsSvc service, IMapper mapper, ILogger<AuthenticationController> logger)
        public AccountController(IAuthenticationSvc service, IImageBankSvc imagebankSvc, IGTINInformationSvc gtininformationSvc, IGCPInformationSvc gcpinformationSvc, IMapper mapper, IOptions<RegistrationAPI_Settings> registrationAPI)
        {
            this._service = service;
            this._mapper = mapper;
            this._registrationAPI = registrationAPI.Value;
            this._gtininformationSvc = gtininformationSvc;
            this._gcpinformationSvc = gcpinformationSvc;
            this._imagebankSvc = imagebankSvc;
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.RAPIAuthentication.MemberLogin)]
        public async Task<IActionResult> MembershipLogin([FromBody] LoginVM model)
        {
            ServiceResponse<AuthenticatedPayload> response = new ServiceResponse<AuthenticatedPayload>
            {
                IsSuccess = false,
                ReturnedObject = null,
                Message = string.Empty
            };
            try
            {
                var baseURL = this._registrationAPI.BaseUrl;
                var loginendpoint = this._registrationAPI.LoginEndPoint;

                var obj = await _service.Login(model, baseURL, loginendpoint);
                response = _mapper.Map<ServiceResponse<AuthenticatedPayload>>(obj);
                return StatusCode(StatusCodes.Status200OK, response);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
        }
    }
}
