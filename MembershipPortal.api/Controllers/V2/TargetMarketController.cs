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
    public class TargetMarketController : ControllerBase
    {
        private readonly ITargetMarketSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<TargetMarketController> _logger;

        public TargetMarketController(ITargetMarketSvc service, IMapper mapper, ILogger<TargetMarketController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitTargetMarketController>
        [HttpGet(ApiRoutes.RTargetMarket.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All GLN records");
                    var result = _mapper.Map<IEnumerable<TargetMarketVM>>(obj);
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
        [HttpGet(ApiRoutes.RTargetMarket.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get TargetMarket with id " + id);
                    var obj = _mapper.Map<TargetMarketVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get TargetMarket with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get TargetMarket with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitTargetMarketController>
        [HttpPost(ApiRoutes.RTargetMarket.Create)]
        public async Task<IActionResult> Post([FromBody] TargetMarketVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create TargetMarket ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    TargetMarket data = _mapper.Map<TargetMarket>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create TargetMarket ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RTargetMarket.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create TargetMarket ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create TargetMarket " + ex);
                return null;
            }

        }

        // PUT api/<BenefitTargetMarketController>/5
        [HttpPut(ApiRoutes.RTargetMarket.Update)]
        public async Task<IActionResult> Put([FromBody] TargetMarketVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update TargetMarket ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<TargetMarket>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update TargetMarket ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update TargetMarket ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update TargetMarket " + ex);
                return null;
            }
        }
    }
}
