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
        [HttpGet(ApiRoutes.RPackageLevel.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All GLN records");
                    var result = _mapper.Map<IEnumerable<PackageLevelVM>>(obj);
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
        [HttpGet(ApiRoutes.RPackageLevel.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get PackageLevel with id " + id);
                    var obj = _mapper.Map<PackageLevelVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get PackageLevel with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get PackageLevel with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitPackageLevelController>
        [HttpPost(ApiRoutes.RPackageLevel.Create)]
        public async Task<IActionResult> Post([FromBody] PackageLevelVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create PackageLevel ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    PackageLevel data = _mapper.Map<PackageLevel>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create PackageLevel ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RPackageLevel.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create PackageLevel ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create PackageLevel " + ex);
                return null;
            }

        }

        // PUT api/<BenefitPackageLevelController>/5
        [HttpPut(ApiRoutes.RPackageLevel.Update)]
        public async Task<IActionResult> Put([FromBody] PackageLevelVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update PackageLevel ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<PackageLevel>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update PackageLevel ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update PackageLevel ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update PackageLevel " + ex);
                return null;
            }
        }
    }
}
