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
    public class PackageLevelController : ControllerBase
    {
        private readonly IPackageLevelSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<PackageLevelController> _logger;

        public PackageLevelController(IPackageLevelSvc service, IMapper mapper, ILogger<PackageLevelController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitPackageLevelController>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RPackageLevel.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            ServiceResponseList<PackageLevelVM> response = new ServiceResponseList<PackageLevelVM>
            {
                ReturnedObject = new List<PackageLevelVM>(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetAll();
            response = _mapper.Map<ServiceResponseList<PackageLevelVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        // GET api/<BenefitController>/5
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RPackageLevel.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            ServiceResponse<PackageLevelVM> response = new ServiceResponse<PackageLevelVM>
            {
                ReturnedObject = new PackageLevelVM(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetByID(id);
            response = _mapper.Map<ServiceResponse<PackageLevelVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
