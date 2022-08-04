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

        // GET api/<BenefitController>/5
        [HttpGet(ApiRoutes.RBrandInformation.GetByRegID)]
        public async Task<IActionResult> GetByRegID(string registrationid)
        {
            try
            {
                var data = await _service.GetByRegistrationID(registrationid);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get BrandInformation with id " + registrationid);
                    var obj = _mapper.Map<BrandInformationVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get BrandInformation with id " + registrationid);
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
            ServiceResponseVM<BrandInformationVM> response = new ServiceResponseVM<BrandInformationVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create BrandInformation ", errors);
                    return BadRequest(errors);
                }

                BrandInformation data = _mapper.Map<BrandInformation>(obj);
                data.isActive = true;
                var result = await _service.Save(data);
                if (result.IsSuccess)
                {
                    response.ReturnedObject = _mapper.Map<BrandInformationVM>(result.ReturnedObject);
                    response.IsSuccess = result.IsSuccess;
                    _logger.LogInformation("Success: Create BrandInformation ", response);
                    var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                    //return Created(locationUrl, response);
                    return StatusCode(StatusCodes.Status201Created, response);
                }
                response.Message = result.Message;
                _logger.LogError("Failed: Create BrandInformation ", response);
                return StatusCode(StatusCodes.Status400BadRequest, response);
                //else
                //{
                //    _logger.LogError("Failed: Create BrandInformation ", result);
                //    return StatusCode(StatusCodes.Status500InternalServerError, result);
                //}
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create BrandInformation " + ex);
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }

        }


        // PUT api/<BenefitBrandInformationController>/5
        [HttpPut(ApiRoutes.RBrandInformation.Update)]
        public async Task<IActionResult> Update([FromBody] BrandInformationVM_CRU model)
        {
            ServiceResponseVM<BrandInformationVM> response = new ServiceResponseVM<BrandInformationVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                    _logger.LogInformation("Failed: Update BrandInformation ", errors);
                    response.Message = errors;
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }
                var newObj = await _service.GetByID(model.id);
                if (model.brandname != newObj.brandname)
                {
                    var data = _mapper.Map<BrandInformation>(model);
                    if (await _service.RecordExist(data))
                    {
                        response.Message = "Brand Name exist in storage.";
                        return StatusCode(StatusCodes.Status400BadRequest, response);
                    }
                }

                if (newObj != null)
                {
                    newObj.brandname = model.brandname;

                    var obj = await _service.Save(newObj);
                    if (obj.IsSuccess)
                    {
                        //response.data = data;
                        response.ReturnedObject = _mapper.Map<BrandInformationVM>(obj.ReturnedObject);
                        response.IsSuccess = obj.IsSuccess;

                        return StatusCode(StatusCodes.Status200OK, response);
                    }
                    response.Message = obj.Message;
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }
                response.Message = "Failed Updating Record.";
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update BrandInformation " + ex);
                response.Message = ex.Message;
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
        }

        // PUT api/<BenefitBrandInformationController>/5
        [HttpPut(ApiRoutes.RBrandInformation.Activate)]
        public async Task<IActionResult> Activate(int id)
        {
            ServiceResponseVM<BrandInformationVM> response = new ServiceResponseVM<BrandInformationVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (id == 0)
                {
                    response.Message = "Problem with request payload.";
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }

                var newObj = await _service.GetByID(id);
                if (newObj != null)
                {
                    newObj.isActive = true;
                    var result = await _service.Save(newObj);
                    if (result.IsSuccess)
                    {
                        response.ReturnedObject = _mapper.Map<BrandInformationVM>(result.ReturnedObject);
                        response.IsSuccess = result.IsSuccess;
                        _logger.LogInformation("Success: Update BrandInformation ", result);
                        return StatusCode(StatusCodes.Status200OK, response);
                    }

                    response.Message = result.Message;
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }
                response.Message = "Failed retrieving requested data.";
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update BrandInformation " + ex);
                response.Message = ex.Message;
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
        }

        [HttpPut(ApiRoutes.RBrandInformation.Deactivate)]
        public async Task<IActionResult> Deactivate(int id)
        {
            ServiceResponseVM<BrandInformationVM> response = new ServiceResponseVM<BrandInformationVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (id == 0)
                {
                    response.Message = "Problem with request payload.";
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }

                var newObj = await _service.GetByID(id);
                if (newObj != null)
                {
                    newObj.isActive = false;
                    var result = await _service.Save(newObj);
                    if (result.IsSuccess)
                    {
                        response.ReturnedObject = _mapper.Map<BrandInformationVM>(result.ReturnedObject);
                        response.IsSuccess = result.IsSuccess;
                        _logger.LogInformation("Success: Update BrandInformation ", result);
                        return StatusCode(StatusCodes.Status200OK, response);
                    }

                    response.Message = result.Message;
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }
                response.Message = "Failed retrieving requested data.";
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update BrandInformation " + ex);
                response.Message = ex.Message;
                return BadRequest(response);
            }
        }
    }
}
