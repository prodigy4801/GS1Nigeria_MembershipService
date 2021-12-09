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
        [HttpGet(ApiRoutes.RBrickCategory.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All BrickCategory records");
                    var result = _mapper.Map<IEnumerable<BrickCategoryVM>>(obj);
                    return Ok(result);
                }

                _logger.LogInformation("Empty: Get All BrickCategory no record");
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get all BrickCategory ", ex);
                return null;
            }
        }

        // GET api/<BenefitController>/5
        [HttpGet(ApiRoutes.RBrickCategory.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get BrickCategory with id " + id);
                    var obj = _mapper.Map<BrickCategoryVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get BrickCategory with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get BrickCategory with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitBrickCategoryController>
        [HttpPost(ApiRoutes.RBrickCategory.Create)]
        public async Task<IActionResult> Post([FromBody] BrickCategoryVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create BrickCategory ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    BrickCategory data = _mapper.Map<BrickCategory>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create BrickCategory ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RBrickCategory.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create BrickCategory ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create BrickCategory " + ex);
                return null;
            }

        }

        // PUT api/<BenefitBrickCategoryController>/5
        [HttpPut(ApiRoutes.RBrickCategory.Update)]
        public async Task<IActionResult> Put([FromBody] BrickCategoryVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update BrickCategory ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<BrickCategory>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update BrickCategory ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update BrickCategory ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update BrickCategory " + ex);
                return null;
            }
        }
    }
}
