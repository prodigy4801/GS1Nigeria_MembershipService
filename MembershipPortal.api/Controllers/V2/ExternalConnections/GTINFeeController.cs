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
using MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend;

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("")]
    [ApiController]
    public class GTINFeeController : ControllerBase
    {
        private readonly IGTINFeeSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<GTINFeeController> _logger;
        private readonly RegistrationAPI_Settings _registrationAPI;

        public GTINFeeController(IGTINFeeSvc service, IMapper mapper, ILogger<GTINFeeController> logger, IOptions<RegistrationAPI_Settings> registrationAPI)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
            this._registrationAPI = registrationAPI.Value;
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RGTINFee.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            ServiceResponseList<GTINFeeVM> response = new ServiceResponseList<GTINFeeVM>
            {
                ReturnedObject = new List<GTINFeeVM>(),
                IsSuccess = true,
                Message = string.Empty
            };
            int skip = 0;
            int take = 16;
            var obj = await _service.GetAll(skip, take);
            response = _mapper.Map<ServiceResponseList<GTINFeeVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RGTINFee.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            ServiceResponse<GTINFeeVM> response = new ServiceResponse<GTINFeeVM>
            {
                ReturnedObject = new GTINFeeVM(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetByID(id);
            response = _mapper.Map<ServiceResponse<GTINFeeVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
