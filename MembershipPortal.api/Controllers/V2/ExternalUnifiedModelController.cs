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
    [ApiExplorerSettings(IgnoreApi = true)]
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
        public async Task<IActionResult> GetAllPagination([FromQuery] RecordPaginationModel pagination)
        {
            try
            {
                int skip = (pagination.PageNumber - 1) * pagination.PageSize;
                int take = pagination.PageSize;
                var obj = await _service.GetAll(skip, take);
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var result = _mapper.Map<IEnumerable<ExternalUnifiedModelVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // GET api/<BenefitController>/5
        [HttpGet(ApiRoutes.RExternalUnifiedModel.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var obj = await _service.GetByID(id);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<ExternalUnifiedModelVM>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // GET api/<BenefitController>/5
        [HttpGet(ApiRoutes.RExternalUnifiedModel.GetByProductID)]
        public async Task<IActionResult> GetByProductID(int productid)
        {
            try
            {
                if (productid < 1)
                {
                    string error = "Invalid request parameter.";
                    return StatusCode(StatusCodes.Status400BadRequest, error);
                }

                var obj = await _service.GetByProductID(productid);
                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<ExternalUnifiedModelVM>(obj);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // POST api/<BenefitExternalUnifiedModelController>
        [HttpPost(ApiRoutes.RExternalUnifiedModel.Create)]
        public async Task<IActionResult> Post([FromBody] ExternalUnifiedModelVM_CRU req)
        {
            ServiceResponse<ExternalUnifiedModelVM> response = new ServiceResponse<ExternalUnifiedModelVM>
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

                ExternalUnifiedModel model = _mapper.Map<ExternalUnifiedModel>(req);
                var obj = await _service.Save(model);
                response = _mapper.Map<ServiceResponse<ExternalUnifiedModelVM>>(obj);
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

        // PUT api/<BenefitExternalUnifiedModelController>/5
        //[HttpPut(ApiRoutes.RExternalUnifiedModel.Update)]
        //public async Task<IActionResult> UpdateExternalUnifiedModel([FromBody] ExternalUnifiedModelVM_CRU req)
        //{
        //    ServiceResponseVM<ExternalUnifiedModelVM> response = new ServiceResponseVM<ExternalUnifiedModelVM>
        //    {
        //        ReturnedObject = null,
        //        IsSuccess = false,
        //        Message = string.Empty
        //    };
        //    try
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            var errors = string.Join("; ", ModelState.Values
        //                                .SelectMany(x => x.Errors)
        //                                .Select(x => x.ErrorMessage));
        //            response.Message = errors;
        //            return StatusCode(StatusCodes.Status400BadRequest, response);
        //        }
        //        var newObj = await _service.GetByID(req.id);
        //        if (newObj.IsSuccess && newObj.ReturnedObject != null)
        //        {
        //            if (newObj.ReturnedObject.product_id != req.product_id)
        //            {
        //                var obj = _mapper.Map<ExternalUnifiedModel>(req);
        //                var isExist = await _service.IsExist(obj);
        //                if (isExist.IsSuccess && isExist.ReturnedObject)
        //                {
        //                    response.Message = "Model exist in storage.";
        //                    return StatusCode(StatusCodes.Status302Found, response);
        //                }
        //            }
        //            newObj.ReturnedObject.product_id = req.product_id;
        //            newObj.ReturnedObject.
        //            var result = await _service.Save(newObj.ReturnedObject);
        //            response = _mapper.Map<ServiceResponseVM<ExternalUnifiedModelVM>>(result);
        //            if (response.IsSuccess)
        //            {
        //                return StatusCode(StatusCodes.Status200OK, response);
        //            }
        //            return StatusCode(StatusCodes.Status304NotModified, response);
        //        }
        //        response.Message = "Brand Information cannot be found.";
        //        return StatusCode(StatusCodes.Status404NotFound, response);
        //    }
        //    catch (Exception ex)
        //    {
        //        response.Message = ex.Message;
        //        return StatusCode(StatusCodes.Status400BadRequest, response);
        //    }
        //}
    }
}
