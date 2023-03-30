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
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RBrandInformation.GetAll)]
        public async Task<IActionResult> GetAllPagination([FromQuery] RecordPaginationModel pagination)
        {

            try
            {
                int skip = (pagination.PageNumber - 1) * pagination.PageSize;
                int take = pagination.PageSize;
                var obj = await _service.GetAll(skip, take);
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var result = _mapper.Map<IEnumerable<BrandInformationVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RBrandInformation.GetActive)]
        public async Task<IActionResult> GetAllActive([FromQuery] RecordPaginationModel pagination)
        {
            try
            {
                int skip = (pagination.PageNumber - 1) * pagination.PageSize;
                int take = pagination.PageSize;
                var obj = await _service.GetAllActive(skip, take);
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var result = _mapper.Map<IEnumerable<BrandInformationVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RBrandInformation.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var obj = await _service.GetByID(id);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<BrandInformationVM>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RBrandInformation.GetByRegID)]
        public async Task<IActionResult> GetByRegID(string registrationid)
        {
            try
            {
                var obj = await _service.GetByRegistrationID(registrationid);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<IEnumerable<BrandInformationVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound(null);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.RBrandInformation.Create)]
        public async Task<IActionResult> Post([FromBody] BrandInformationVM_Create req)
        {
            ServiceResponse<BrandInformationVM> response = new ServiceResponse<BrandInformationVM>
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

                BrandInformation model = _mapper.Map<BrandInformation>(req);
                var obj = await _service.Save(model);
                response = _mapper.Map<ServiceResponse<BrandInformationVM>>(obj);
                if (response.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, response);
                }
                return StatusCode(StatusCodes.Status400BadRequest, response);
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return StatusCode(StatusCodes.Status403Forbidden, response);
            }

        }

        [AllowAnonymous]
        [HttpPut(ApiRoutes.RBrandInformation.Update)]
        public async Task<IActionResult> UpdateBrandInformation([FromBody] BrandInformationVM_Update req)
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
                    response.Message = errors;
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }
                var newObj = await _service.GetByID(req.id);
                if (newObj.IsSuccess && newObj.ReturnedObject != null)
                {
                    if (newObj.ReturnedObject.brandname != req.brandname)
                    {
                        var obj = _mapper.Map<BrandInformation>(req);
                        var isExist = await _service.IsExist(obj);
                        if (isExist.IsSuccess && isExist.ReturnedObject)
                        {
                            response.Message = "Brand Name exist in storage.";
                            return StatusCode(StatusCodes.Status302Found, response);
                        }
                    }
                    newObj.ReturnedObject.brandname = req.brandname;
                    var result = await _service.Save(newObj.ReturnedObject);
                    response = _mapper.Map<ServiceResponseVM<BrandInformationVM>>(result);
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

        [AllowAnonymous]
        [HttpPut(ApiRoutes.RBrandInformation.ChangeStatus)]
        public async Task<IActionResult> ChangeActivationStatus([FromQuery] BrandInformationVM_ActivationStatus model)
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
                    response.Message = errors;
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }

                var newObj = await _service.GetByID(model.id);
                if (newObj.IsSuccess && newObj.ReturnedObject != null)
                {
                    newObj.ReturnedObject.isActive = model.isActive;
                    var result = await _service.Save(newObj.ReturnedObject);
                    response = _mapper.Map<ServiceResponseVM<BrandInformationVM>>(result);
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
