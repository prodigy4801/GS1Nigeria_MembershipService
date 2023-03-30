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
    public class ProductTargetMarketController : ControllerBase
    {
        private readonly IProductTargetMarketSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductTargetMarketController> _logger;

        public ProductTargetMarketController(IProductTargetMarketSvc service, IMapper mapper, ILogger<ProductTargetMarketController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitProductTargetMarketController>
        [AllowAnonymous]
        [HttpGet(ApiRoutes.RProductTargetMarket.GetAll)]
        public async Task<IActionResult> GetAllPagination([FromQuery] RecordPaginationModel pagination)
        {
            try
            {
                int skip = (pagination.PageNumber - 1) * pagination.PageSize;
                int take = pagination.PageSize;
                var obj = await _service.GetAll(skip, take);
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var result = _mapper.Map<IEnumerable<ProductTargetMarketVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound(obj.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RProductTargetMarket.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var obj = await _service.GetByID(id);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<ProductTargetMarketVM>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound(obj.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RProductTargetMarket.GetByRegistrationID)]
        public async Task<IActionResult> GetByRegID(string registrationid)
        {
            try
            {
                var obj = await _service.GetByRegistrationID(registrationid);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<IEnumerable<ProductTargetMarketVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound(obj.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RProductTargetMarket.GetByKey)]
        public async Task<IActionResult> GetByKey(ProductTargetMarketVM_Key key)
        {
            try
            {
                var obj = await _service.GetByProductRegistrationID(key.product_id, key.registrationid);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<IEnumerable<ProductTargetMarketVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound(obj.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.RProductTargetMarket.Create)]
        public async Task<IActionResult> Post([FromBody] ProductTargetMarketVM_Create req)
        {
            ServiceResponse<ProductTargetMarketVM> response = new ServiceResponse<ProductTargetMarketVM>
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

                ProductTargetMarket model = _mapper.Map<ProductTargetMarket>(req);
                var obj = await _service.Save(model);
                response = _mapper.Map<ServiceResponse<ProductTargetMarketVM>>(obj);
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
    }
}
