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
//using MembershipPortal.api.Authorization;

namespace MembershipPortal.api.Controllers.V2
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalUnifiedModelController : ControllerBase
    {
        private readonly IExternalUnifiedModelSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<ExternalUnifiedModelController> _logger;

        public ExternalUnifiedModelController(IExternalUnifiedModelSvc service, IMapper mapper, ILogger<ExternalUnifiedModelController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitExternalUnifiedModelController>
        [HttpGet(ApiRoutes.RExternalUnifiedModel.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All ExternalUnifiedModel records");
                    var result = _mapper.Map<IEnumerable<ExternalUnifiedModelVM>>(obj);
                    return Ok(result);
                }

                _logger.LogInformation("Empty: Get All ExternalUnifiedModel no record");
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get all ExternalUnifiedModel ", ex);
                return null;
            }
        }

        // GET api/<BenefitController>/5
        [HttpGet(ApiRoutes.RExternalUnifiedModel.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get ExternalUnifiedModel with id " + id);
                    var obj = _mapper.Map<ExternalUnifiedModelVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get ExternalUnifiedModel with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get ExternalUnifiedModel with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitExternalUnifiedModelController>
        [HttpPost(ApiRoutes.RExternalUnifiedModel.Create)]
        public async Task<IActionResult> Post([FromBody] ExternalUnifiedModelVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create ExternalUnifiedModel ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    ExternalUnifiedModel data = _mapper.Map<ExternalUnifiedModel>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create ExternalUnifiedModel ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RExternalUnifiedModel.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create ExternalUnifiedModel ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create ExternalUnifiedModel " + ex);
                return null;
            }

        }

        // PUT api/<BenefitExternalUnifiedModelController>/5
        [HttpPut(ApiRoutes.RExternalUnifiedModel.Update)]
        public async Task<IActionResult> Put([FromBody] ExternalUnifiedModelVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update ExternalUnifiedModel ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<ExternalUnifiedModel>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update ExternalUnifiedModel ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update ExternalUnifiedModel ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update ExternalUnifiedModel " + ex);
                return null;
            }
        }
    }
}
