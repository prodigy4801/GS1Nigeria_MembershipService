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
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All GLN records");
                    var result = _mapper.Map<IEnumerable<GTINInformationVM>>(obj);
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
        [HttpGet(ApiRoutes.RGTINInformation.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get GTINInformation with id " + id);
                    var obj = _mapper.Map<GTINInformationVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get GTINInformation with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get GTINInformation with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitGTINInformationController>
        [HttpPost(ApiRoutes.RGTINInformation.Create)]
        public async Task<IActionResult> Post([FromBody] GTINInformationVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create GTINInformation ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    GTINInformation data = _mapper.Map<GTINInformation>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create GTINInformation ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RGTINInformation.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create GTINInformation ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create GTINInformation " + ex);
                return null;
            }

        }

        // PUT api/<BenefitGTINInformationController>/5
        [HttpPut(ApiRoutes.RGTINInformation.Update)]
        public async Task<IActionResult> Put([FromBody] GTINInformationVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update GTINInformation ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<GTINInformation>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update GTINInformation ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update GTINInformation ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update GTINInformation " + ex);
                return null;
            }
        }
    }
}
