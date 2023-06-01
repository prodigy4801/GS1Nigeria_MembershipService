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
        private readonly IJwtUtils _jwtUtils;
        //private IJwtUtils _jwtUtils;
        //private readonly AppSettings _appSettings;
        //private readonly ILogger<AuthenticationController> _logger;

        //public AuthenticationController(IJwtUtils jwtUtils, IAPICredentialsSvc service, IMapper mapper, ILogger<AuthenticationController> logger)
        public AccountController(IAuthenticationSvc service, IImageBankSvc imagebankSvc, IGTINInformationSvc gtininformationSvc, IGCPInformationSvc gcpinformationSvc, IMapper mapper, IOptions<RegistrationAPI_Settings> registrationAPI, IJwtUtils jwtUtils)
        {
            this._service = service;
            this._mapper = mapper;
            this._registrationAPI = registrationAPI.Value;
            this._gtininformationSvc = gtininformationSvc;
            this._gcpinformationSvc = gcpinformationSvc;
            this._imagebankSvc = imagebankSvc;
            this._jwtUtils = jwtUtils;
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

            var baseURL = this._registrationAPI.BaseUrl;
            var loginendpoint = this._registrationAPI.LoginEndPoint;

            var obj = await _service.Login(model, baseURL, loginendpoint);
            response = _mapper.Map<ServiceResponse<AuthenticatedPayload>>(obj);
            if (response.IsSuccess && response.ReturnedObject != null)
            {
                //Generate Token for User management
                JWTTokenValueModel jwtToken = new JWTTokenValueModel
                {
                    companyname = response.ReturnedObject.Companies.companyname,
                    email = response.ReturnedObject.email,
                    registrationID = obj.ReturnedObject.registrationid
                };
                var tokenObj = _jwtUtils.GenerateJWTToken(jwtToken);
                if (tokenObj != null && tokenObj.IsSuccess && tokenObj.ReturnedObject != null)
                {
                    response.ReturnedObject.tokenValidation = tokenObj.ReturnedObject;
                }
                else
                {
                    response.Message = tokenObj.Message;
                }
            }
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.RAPIAuthentication.MemberForgotPassword)]
        public async Task<IActionResult> ForgotPassword([FromBody] Authentication_ForgotPassword model)
        {
            ServiceResponse<PasswordReset_Response> response = new ServiceResponse<PasswordReset_Response>
            {
                IsSuccess = false,
                ReturnedObject = new PasswordReset_Response(),
                Message = string.Empty
            };

            var baseURL = this._registrationAPI.BaseUrl;
            var forgotpasswordendpoint = this._registrationAPI.ForgotPassword;

            var obj = await _service.ForgotPassword(model, baseURL, forgotpasswordendpoint);
            response = _mapper.Map<ServiceResponse<PasswordReset_Response>>(obj);

            return StatusCode(StatusCodes.Status200OK, response);
        }

        //[AllowAnonymous]
        [HttpPost(ApiRoutes.RAPIAuthentication.MemberPasswordChange)]
        public async Task<IActionResult> PasswordChange([FromBody] Authenticate_PasswordReset request)
        {
            ServiceResponse<PasswordReset_Response> response = new ServiceResponse<PasswordReset_Response>
            {
                IsSuccess = false,
                ReturnedObject = new PasswordReset_Response(),
                Message = string.Empty
            };

            var obj = await _service.PasswordChange(request.email, request.currentpassword, request.newpassword);
            response.IsSuccess = obj.IsSuccess;
            response.Message = obj.Message;
            response.ReturnedObject.email = request.email;
            response.ReturnedObject.resetstatus = obj.IsSuccess && obj.ReturnedObject != null ? true : false;

            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
