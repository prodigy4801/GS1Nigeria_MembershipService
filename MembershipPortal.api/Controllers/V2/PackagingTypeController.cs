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
        public async Task<IActionResult> GetAllPagination()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var result = _mapper.Map<IEnumerable<PackagingTypeVM>>(obj.ReturnedObject);
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
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RPackagingType.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var obj = await _service.GetByID(id);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<PackagingTypeVM>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // POST api/<BenefitPackagingTypeController>
        [HttpPost(ApiRoutes.RPackagingType.Create)]
        public async Task<IActionResult> Post([FromBody] PackagingTypeVM_CRU req)
        {
            ServiceResponse<PackagingTypeVM> response = new ServiceResponse<PackagingTypeVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                    response.Message = errors;
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }

                PackagingType model = _mapper.Map<PackagingType>(req);
                var obj = await _service.Save(model);
                response = _mapper.Map<ServiceResponse<PackagingTypeVM>>(obj);
                if (response.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, response);
                }
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return StatusCode(StatusCodes.Status403Forbidden, response);
            }
        }
    }
}
