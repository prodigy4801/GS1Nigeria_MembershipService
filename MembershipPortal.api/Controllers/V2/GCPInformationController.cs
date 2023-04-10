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
    public class GCPInformationController : ControllerBase
    {
        private readonly IGCPInformationSvc _service;
        private readonly IMapper _mapper;
        private readonly ILogger<GCPInformationController> _logger;

        public GCPInformationController(IGCPInformationSvc service, IMapper mapper, ILogger<GCPInformationController> logger)
        {
            this._service = service;
            this._mapper = mapper;
            this._logger = logger;
        }
        //[AllowAnonymous]
        [HttpGet(ApiRoutes.RGCPInformation.GetAll)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> GetAllPagination([FromQuery] RecordPaginationModel pagination)
        {
            try
            {
                int skip = (pagination.PageNumber - 1) * pagination.PageSize;
                int take = pagination.PageSize;
                var obj = await _service.GetAll(skip, take);
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var result = _mapper.Map<IEnumerable<GCPInformationVM>>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        //[AllowAnonymous]
        [HttpGet(ApiRoutes.RGCPInformation.GetByID)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var obj = await _service.GetByID(id);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<GCPInformationVM>(obj.ReturnedObject);
                    return Ok(result);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        //[AllowAnonymous]
        [HttpGet(ApiRoutes.RGCPInformation.GetByRegistrationID)]
        public async Task<IActionResult> GetByRegID(string registrationid)
        {
            ServiceResponseList<GCPInformationVM> response = new ServiceResponseList<GCPInformationVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };

            var obj = await _service.GetListByRegistrationID(registrationid);
            response = _mapper.Map<ServiceResponseList<GCPInformationVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        //[AllowAnonymous]
        [HttpPost(ApiRoutes.RGCPInformation.Create)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> Post([FromBody] GCPInformationVM_Create req)
        {
            ServiceResponse<GCPInformationVM> response = new ServiceResponse<GCPInformationVM>
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

                GCPInformation model = _mapper.Map<GCPInformation>(req);
                var obj = await _service.Save(model);
                response = _mapper.Map<ServiceResponse<GCPInformationVM>>(obj);
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

        //[AllowAnonymous]
        [HttpPost(ApiRoutes.RGCPInformation.ChangeActiveStatus)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ChangeActivation([FromQuery] GCPInformationVM_ChangeStatus req)
        {
            ServiceResponse<GCPInformationVM> response = new ServiceResponse<GCPInformationVM>
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

                //Get information by registrationID
                var gcpRecord = await _service.GetByID(req.id);
                if(gcpRecord.IsSuccess && gcpRecord.ReturnedObject != null)
                {
                    string statusChangeMSG = req.Active ? " Activated Company Prefix" : " Deactivated Company Prefix";
                    gcpRecord.ReturnedObject.Active = req.Active;
                    gcpRecord.ReturnedObject.DateOfIssuance = req.Active ? DateTime.Now : gcpRecord.ReturnedObject.DateOfIssuance;
                    var obj = await _service.Save(gcpRecord.ReturnedObject);
                    response = _mapper.Map<ServiceResponse<GCPInformationVM>>(obj);
                    if (response.IsSuccess)
                    {
                        response.Message += statusChangeMSG;
                        return StatusCode(StatusCodes.Status201Created, response);
                    }
                    return StatusCode(StatusCodes.Status400BadRequest, response);
                }
                response.Message = "Failed in retrieving Company Information."; 
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
