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
            try
            {
                var obj = await _service.GetAll();
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var result = _mapper.Map<IEnumerable<BrickCategoryVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                _logger.LogInformation("Empty: Get All GLN no record");
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // GET api/<BenefitController>/5
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RBrickCategory.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var obj = await _service.GetByID(id);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    _logger.LogInformation("Success: Get BrickCategory with id " + id);
                    var result = _mapper.Map<BrickCategoryVM>(obj);
                    return Ok(result);
                }

                _logger.LogInformation("NULL: Get BrickCategory with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // POST api/<BenefitBrickCategoryController>
        [HttpPost(ApiRoutes.RBrickCategory.Create)]
        public async Task<IActionResult> Post([FromBody] BrickCategoryVM_CRU req)
        {
            ServiceResponse<BrickCategoryVM> result = new ServiceResponse<BrickCategoryVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create BrickCategory ", errors);
                    return BadRequest(errors);
                }

                BrickCategory model = _mapper.Map<BrickCategory>(req);
                var obj = await _service.Save(model);
                result = _mapper.Map<ServiceResponse<BrickCategoryVM>>(obj);
                if (result.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, result);
                }
                return StatusCode(StatusCodes.Status400BadRequest, result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return StatusCode(StatusCodes.Status403Forbidden, result);
            }

        }
    }
}
