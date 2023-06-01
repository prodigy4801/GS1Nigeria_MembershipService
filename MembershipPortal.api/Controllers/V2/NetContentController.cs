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
    public class NetContentController : ControllerBase
    {
        private readonly INetContentSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<NetContentController> _logger;

        public NetContentController(INetContentSvc service, IMapper mapper, ILogger<NetContentController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitNetContentController>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RNetContent.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            ServiceResponseList<NetContentVM> response = new ServiceResponseList<NetContentVM>
            {
                ReturnedObject = new List<NetContentVM>(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetAll();
            response = _mapper.Map<ServiceResponseList<NetContentVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        // GET api/<BenefitController>/5
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RNetContent.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            ServiceResponse<NetContentVM> response = new ServiceResponse<NetContentVM>
            {
                ReturnedObject = new NetContentVM(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetByID(id);
            response = _mapper.Map<ServiceResponse<NetContentVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
