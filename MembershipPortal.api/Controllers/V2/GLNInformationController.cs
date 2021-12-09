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
    public class GLNInformationController : ControllerBase
    {
        private readonly IGLNInformationSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<GLNInformationController> _logger;

        public GLNInformationController(IGLNInformationSvc service, IMapper mapper, ILogger<GLNInformationController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitGLNInformationController>
        [HttpGet(ApiRoutes.RGLNInformation.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All GLN records");
                    var result = _mapper.Map<IEnumerable<GLNInformationVM>>(obj);
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
        [HttpGet(ApiRoutes.RGLNInformation.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get GLNInformation with id " + id);
                    var obj = _mapper.Map<GLNInformationVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get GLNInformation with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get GLNInformation with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitGLNInformationController>
        [HttpPost(ApiRoutes.RGLNInformation.Create)]
        public async Task<IActionResult> Post([FromBody] GLNInformationVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create GLNInformation ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    GLNInformation data = _mapper.Map<GLNInformation>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create GLNInformation ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RGLNInformation.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create GLNInformation ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create GLNInformation " + ex);
                return null;
            }

        }

        // PUT api/<BenefitGLNInformationController>/5
        [HttpPut(ApiRoutes.RGLNInformation.Update)]
        public async Task<IActionResult> Put([FromBody] GLNInformationVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update GLNInformation ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<GLNInformation>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update GLNInformation ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update GLNInformation ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update GLNInformation " + ex);
                return null;
            }
        }
    }
}
