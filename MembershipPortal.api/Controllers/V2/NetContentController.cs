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
    // [Authorize]
    [Route("")]
    [ApiController]
    public class NetContentController : ControllerBase
    {
        private readonly INetContentSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<NetContentController> _logger;

        public NetContentController(INetContentSvc service, IMapper mapper, ILogger<NetContentController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitNetContentController>
        [HttpGet(ApiRoutes.RNetContent.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All GLN records");
                    var result = _mapper.Map<IEnumerable<NetContentVM>>(obj);
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
        [HttpGet(ApiRoutes.RNetContent.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get NetContent with id " + id);
                    var obj = _mapper.Map<NetContentVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get NetContent with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get NetContent with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitNetContentController>
        [HttpPost(ApiRoutes.RNetContent.Create)]
        public async Task<IActionResult> Post([FromBody] NetContentVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create NetContent ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    NetContent data = _mapper.Map<NetContent>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create NetContent ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RNetContent.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create NetContent ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create NetContent " + ex);
                return null;
            }

        }

        // PUT api/<BenefitNetContentController>/5
        [HttpPut(ApiRoutes.RNetContent.Update)]
        public async Task<IActionResult> Put([FromBody] NetContentVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update NetContent ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<NetContent>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update NetContent ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update NetContent ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update NetContent " + ex);
                return null;
            }
        }
    }
}
