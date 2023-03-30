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

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
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

        [AllowAnonymous]
        [HttpGet(ExternalApiRoutes.RCompany.GetByRegistrationID)]
        public async Task<IActionResult> GetByRegID(string registrationid)
        {
            GenericResponse<CompanyModel> response = new GenericResponse<CompanyModel>
            {
                IsSuccess = false,
                ReturnedObject = null,
                Message = string.Empty
            };
            try
            {
                var tokenValidation = Request.Headers["Authorization"].SingleOrDefault();
                if (tokenValidation == null)
                {
                    response.Message = "Please pass your token to get Access to service";
                    return BadRequest(response);
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

                response = await _service.GetByRegistrationID(registrationid,servicerequest);
                if (response.ReturnedObject == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, response);
                }

                return StatusCode(StatusCodes.Status200OK, response);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
        }
    }
}
