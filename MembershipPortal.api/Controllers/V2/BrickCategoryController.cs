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
    public class BrickCategoryController : ControllerBase
    {
        private readonly IBrickCategorySvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<BrickCategoryController> _logger;

        public BrickCategoryController(IBrickCategorySvc service, IMapper mapper, ILogger<BrickCategoryController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitBrickCategoryController>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RBrickCategory.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            ServiceResponseList<BrickCategoryVM> response = new ServiceResponseList<BrickCategoryVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };

            var obj = await _service.GetAll();
            response = _mapper.Map<ServiceResponseList<BrickCategoryVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        // GET api/<BenefitController>/5
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RBrickCategory.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            ServiceResponse<BrickCategoryVM> response = new ServiceResponse<BrickCategoryVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };

            var obj = await _service.GetByID(id);
            response = _mapper.Map<ServiceResponse<BrickCategoryVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
