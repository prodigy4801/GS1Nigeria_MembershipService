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

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("")]
    [ApiController]
    public class PackagingTypeController : ControllerBase
    {
        private readonly IPackagingTypeSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<PackagingTypeController> _logger;

        public PackagingTypeController(IPackagingTypeSvc service, IMapper mapper, ILogger<PackagingTypeController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitPackagingTypeController>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RPackagingType.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            ServiceResponseList<PackagingTypeVM> response = new ServiceResponseList<PackagingTypeVM>
            {
                ReturnedObject = new List<PackagingTypeVM>(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetAll();
            response = _mapper.Map<ServiceResponseList<PackagingTypeVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        // GET api/<BenefitController>/5
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RPackagingType.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            ServiceResponse<PackagingTypeVM> response = new ServiceResponse<PackagingTypeVM>
            {
                ReturnedObject = new PackagingTypeVM(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetByID(id);
            response = _mapper.Map<ServiceResponse<PackagingTypeVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
