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
    public class TargetMarketController : ControllerBase
    {
        private readonly ITargetMarketSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<TargetMarketController> _logger;

        public TargetMarketController(ITargetMarketSvc service, IMapper mapper, ILogger<TargetMarketController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitTargetMarketController>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RTargetMarket.GetAll)]
        public async Task<IActionResult> GetAllPagination()
        {
            ServiceResponseList<TargetMarketVM> response = new ServiceResponseList<TargetMarketVM>
            {
                ReturnedObject = new List<TargetMarketVM>(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetAll();
            response = _mapper.Map<ServiceResponseList<TargetMarketVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        // GET api/<BenefitController>/5
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RTargetMarket.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            ServiceResponse<TargetMarketVM> response = new ServiceResponse<TargetMarketVM>
            {
                ReturnedObject = new TargetMarketVM(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetByID(id);
            response = _mapper.Map<ServiceResponse<TargetMarketVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
