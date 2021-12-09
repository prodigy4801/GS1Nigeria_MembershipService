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
    [Route("api/[controller]")]
    [ApiController]
    public class ITFInformationController : ControllerBase
    {
        private readonly IITFInformationSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<ITFInformationController> _logger;

        public ITFInformationController(IITFInformationSvc service, IMapper mapper, ILogger<ITFInformationController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitITFInformationController>
        [HttpGet(ApiRoutes.RITFInformation.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All GLN records");
                    var result = _mapper.Map<IEnumerable<ITFInformationVM>>(obj);
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
        [HttpGet(ApiRoutes.RITFInformation.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get ITFInformation with id " + id);
                    var obj = _mapper.Map<ITFInformationVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get ITFInformation with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get ITFInformation with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitITFInformationController>
        [HttpPost(ApiRoutes.RITFInformation.Create)]
        public async Task<IActionResult> Post([FromBody] ITFInformationVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create ITFInformation ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    ITFInformation data = _mapper.Map<ITFInformation>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create ITFInformation ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RITFInformation.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create ITFInformation ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create ITFInformation " + ex);
                return null;
            }

        }

        // PUT api/<BenefitITFInformationController>/5
        [HttpPut(ApiRoutes.RITFInformation.Update)]
        public async Task<IActionResult> Put([FromBody] ITFInformationVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update ITFInformation ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<ITFInformation>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update ITFInformation ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update ITFInformation ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update ITFInformation " + ex);
                return null;
            }
        }
    }
}
