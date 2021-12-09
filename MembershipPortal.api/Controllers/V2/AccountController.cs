using AutoMapper;
using MembershipPortal.api.Authorization;
using MembershipPortal.api.Contract.V2;
using MembershipPortal.api.Helpers;
using MembershipPortal.api.Helpers.RegistrationAPIService;
using MembershipPortal.api.Helpers.RegistrationAPIService.Request;
using MembershipPortal.api.Helpers.RegistrationAPIService.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Controllers.V2
{
    [Route("")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAPICredentialsService _service;
        private readonly IMapper _mapper;
        //private IJwtUtils _jwtUtils;
        //private readonly AppSettings _appSettings;
        //private readonly ILogger<AuthenticationController> _logger;

        //public AuthenticationController(IJwtUtils jwtUtils, IAPICredentialsSvc service, IMapper mapper, ILogger<AuthenticationController> logger)
        public AccountController(IAPICredentialsService service, IMapper mapper)
        {
            this._service = service;
            this._mapper = mapper;
            //this._logger = logger;
            //this._jwtAuth = jwtAuth;
            //this._jwtUtils = jwtUtils;
        }
                
        [HttpPost(ApiRoutes.RAPIAuthentication.AuthenticateCredentials)]
        public GenerateTokenResponse GenerateToken(GenerateTokenRequest model)
        {
            GenerateTokenResponse response = new GenerateTokenResponse();

            if(model == null || string.IsNullOrEmpty(model.password) || string.IsNullOrEmpty(model.username))
            {
                //_logger.LogInformation("Failed Authentication: Username or password is incorrect");
                throw new AppException("Invalid Username or password");
            }

            response = _service.GenerateToken(model);

            return response;
        }
    }
}
