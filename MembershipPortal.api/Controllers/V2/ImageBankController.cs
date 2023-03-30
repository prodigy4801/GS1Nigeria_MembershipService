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
using MembershipPortal.api.Models;

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("")]
    [ApiController]
    public class ImageBankController : ControllerBase
    {
        private readonly IImageBankSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<ImageBankController> _logger;

        public ImageBankController(IImageBankSvc service, IMapper mapper, ILogger<ImageBankController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitImageBankController>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RImageBank.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var result = _mapper.Map<IEnumerable<ImageBankVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                _logger.LogInformation("Empty: Get All GLN no record");
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // GET api/<BenefitController>/5
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RImageBank.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var obj = await _service.GetByID(id);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<ImageBankVM>(obj.ReturnedObject);
                    return Ok(result);
                }

                _logger.LogInformation("NULL: Get ImageBank with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RImageBank.GetByRegistrationID)]
        public async Task<IActionResult> GetByRegistrationID(string registrationid)
        {
            try
            {
                var obj = await _service.GetByRegistrationID(registrationid);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<ImageBankVM>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // POST api/<BenefitImageBankController>
        [AllowAnonymous]
        [HttpPost(ApiRoutes.RImageBank.Create)]
        public async Task<IActionResult> Post([FromBody] ImageBankVM_create req)
        {
            ServiceResponse<ImageBankVM> result = new ServiceResponse<ImageBankVM>
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
                    return BadRequest(errors);
                }

                ImageBank model = _mapper.Map<ImageBank>(req);
                var obj = await _service.Save(model);
                result = _mapper.Map<ServiceResponse<ImageBankVM>>(obj);
                if (result.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, result);
                }
                return StatusCode(StatusCodes.Status400BadRequest, result);
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return StatusCode(StatusCodes.Status403Forbidden, result);
            }

        }

        [AllowAnonymous]
        [HttpPut(ApiRoutes.RImageBank.Update)]
        public async Task<IActionResult> UpdateImageBank([FromBody] ImageBankVM_update req)
        {
            ServiceResponse<ImageBankVM> response = new ServiceResponse<ImageBankVM>
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
                    response.Message = errors;
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }
                var newObj = await _service.GetByID(req.id);
                if (newObj.IsSuccess && newObj.ReturnedObject != null)
                {
                    newObj.ReturnedObject.imageReserve = req.imageReserve;
                    var result = await _service.Save(newObj.ReturnedObject);
                    response = _mapper.Map<ServiceResponse<ImageBankVM>>(result);
                    if (response.IsSuccess)
                    {
                        return StatusCode(StatusCodes.Status200OK, response);
                    }
                    return StatusCode(StatusCodes.Status304NotModified, response);
                }
                response.Message = "Brand Information cannot be found.";
                return StatusCode(StatusCodes.Status404NotFound, response);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
        }

    }
}
