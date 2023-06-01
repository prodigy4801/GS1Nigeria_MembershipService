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
using MembershipPortal.data.ExternalEntries.Models;
using MembershipPortal.service.Concrete.ExternalEntries;
using MembershipPortal.data;
using MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend;

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanySvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<CompanyController> _logger;
        private readonly RegistrationAPI_Settings _registrationAPI;

        public CompanyController(ICompanySvc service, IMapper mapper, ILogger<CompanyController> logger, IOptions<RegistrationAPI_Settings> registrationAPI)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
            this._registrationAPI = registrationAPI.Value;
        }

        //[AllowAnonymous]
        [HttpGet(ExternalApiRoutes.RCompany.GetByRegistrationID)]
        public async Task<IActionResult> GetByRegID(string registrationid)
        {
            ServiceResponse<CompanyVM> response = new ServiceResponse<CompanyVM>
            {
                IsSuccess = false,
                ReturnedObject = null,
                Message = string.Empty
            };
            var tokenValidation = Request.Headers["Authorization"].SingleOrDefault();
            if (tokenValidation == null)
            {
                response.Message = "Please pass your token to get Access to service";
                return StatusCode(StatusCodes.Status200OK, response);
                //return BadRequest(response);
            }
            var token = tokenValidation.Split(" ").Last();
            var baseURL = this._registrationAPI.BaseUrl;
            var endpoint = "api/v2/company/getbyregid";

            ExternalCallModels servicerequest = new ExternalCallModels()
            {
                baseURL = baseURL,
                endpoint = endpoint,
                Token = token
            };

            var obj = await _service.GetByRegistrationID(registrationid, servicerequest);
            response = _mapper.Map<ServiceResponse<CompanyVM>>(obj);

            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
