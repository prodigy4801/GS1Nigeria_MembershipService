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
    public class BrandInformationController : ControllerBase
    {
        private readonly IBrandInformationSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<BrandInformationController> _logger;

        public BrandInformationController(IBrandInformationSvc service, IMapper mapper, ILogger<BrandInformationController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitBrandInformationController>
        [HttpGet(ApiRoutes.RBrandInformation.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All GLN records");
                    var result = _mapper.Map<IEnumerable<BrandInformationVM>>(obj);
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
        [HttpGet(ApiRoutes.RBrandInformation.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get BrandInformation with id " + id);
                    var obj = _mapper.Map<BrandInformationVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get BrandInformation with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get BrandInformation with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitBrandInformationController>
        [HttpPost(ApiRoutes.RBrandInformation.Create)]
        public async Task<IActionResult> Post([FromBody] BrandInformationVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create BrandInformation ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    BrandInformation data = _mapper.Map<BrandInformation>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create BrandInformation ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RBrandInformation.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create BrandInformation ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create BrandInformation " + ex);
                return null;
            }

        }


        // PUT api/<BenefitBrandInformationController>/5
        [HttpPut(ApiRoutes.RBrandInformation.Update)]
        public async Task<IActionResult> Put([FromBody] BrandInformationVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update BrandInformation ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<BrandInformation>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update BrandInformation ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update BrandInformation ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update BrandInformation " + ex);
                return null;
            }
        }
    }
}
