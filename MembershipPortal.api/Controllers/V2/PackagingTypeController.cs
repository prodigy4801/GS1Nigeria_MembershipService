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
        [HttpGet(ApiRoutes.RPackagingType.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All GLN records");
                    var result = _mapper.Map<IEnumerable<PackagingTypeVM>>(obj);
                    return Ok(result);
                }

                _logger.LogInformation("Empty: Get All GLN no record");
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get all GLN ", ex);
                return null;
            }
        }

        // GET api/<BenefitController>/5
        [HttpGet(ApiRoutes.RPackagingType.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get PackagingType with id " + id);
                    var obj = _mapper.Map<PackagingTypeVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get PackagingType with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get PackagingType with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitPackagingTypeController>
        [HttpPost(ApiRoutes.RPackagingType.Create)]
        public async Task<IActionResult> Post([FromBody] PackagingTypeVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create PackagingType ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    PackagingType data = _mapper.Map<PackagingType>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create PackagingType ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RPackagingType.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create PackagingType ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create PackagingType " + ex);
                return null;
            }

        }

        // PUT api/<BenefitPackagingTypeController>/5
        [HttpPut(ApiRoutes.RPackagingType.Update)]
        public async Task<IActionResult> Put([FromBody] PackagingTypeVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update PackagingType ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<PackagingType>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update PackagingType ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update PackagingType ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update PackagingType " + ex);
                return null;
            }
        }
    }
}
