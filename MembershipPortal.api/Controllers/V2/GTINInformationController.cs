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
    public class GTINInformationController : ControllerBase
    {
        private readonly IGTINInformationSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<GTINInformationController> _logger;

        public GTINInformationController(IGTINInformationSvc service, IMapper mapper, ILogger<GTINInformationController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitGTINInformationController>
        [HttpGet(ApiRoutes.RGTINInformation.GetAll)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> GetAllPagination([FromQuery] RecordPaginationModel pagination)
        {
            try
            {
                int skip = (pagination.PageNumber - 1) * pagination.PageSize;
                int take = pagination.PageSize;
                var obj = await _service.GetAll(skip, take);
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var result = _mapper.Map<IEnumerable<GTINInformationVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // GET api/<BenefitController>/5
        [HttpGet(ApiRoutes.RGTINInformation.GetByID)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var obj = await _service.GetByID(id);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<GTINInformationVM>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // GET api/<BenefitController>/5
        [HttpGet(ApiRoutes.RGTINInformation.GetByRegistrationID)]
        public async Task<IActionResult> GetByRegID(string registrationid)
        {
            ServiceResponseList<GTINInformationVM> response = new ServiceResponseList<GTINInformationVM>
            {
                ReturnedObject = new List<GTINInformationVM>(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetListByRegistrationID(registrationid);
            response = _mapper.Map<ServiceResponseList<GTINInformationVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        // POST api/<BenefitGTINInformationController>
        [HttpPost(ApiRoutes.RGTINInformation.Create)]
        public async Task<IActionResult> Post([FromBody] GTINInformationVM_Create req)
        {
            ServiceResponse<GTINInformationVM> response = new ServiceResponse<GTINInformationVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            if (!ModelState.IsValid)
            {
                var errors = string.Join("; ", ModelState.Values
                                    .SelectMany(x => x.Errors)
                                    .Select(x => x.ErrorMessage));
                response.Message = errors;
                return StatusCode(StatusCodes.Status200OK, response);
            }

            GTINInformation model = _mapper.Map<GTINInformation>(req);
            var obj = await _service.Save(model);
            response = _mapper.Map<ServiceResponse<GTINInformationVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
