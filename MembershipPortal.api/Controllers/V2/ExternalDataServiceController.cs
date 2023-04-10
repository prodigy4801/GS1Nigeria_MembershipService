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
using MembershipPortal.service.MasterDataDTO;

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ExternalDataServiceController : ControllerBase
    {
        private readonly ILogger<ExternalDataServiceController> _logger;
        private readonly IDataService _service;

        public ExternalDataServiceController(IDataService service, ILogger<ExternalDataServiceController> logger)
        {
            this._service = service;
            this._logger = logger;
        }

        [HttpPost("productbygtin")]
        public async Task<ReturnSignature<ProductDTO>> GetProductByGtin(ProductByGtinPayload payload)
        {
            var result = await _service.GetProductByGtin(payload);

            return result;
        }

        [HttpPost("productbyemail")]
        public async Task<ReturnSignature<List<ProductDTO>>> GetProductByEmail(ProductByEmailPayload payload)
        {
            var result = await _service.GetProductByEmail(payload);
            return result;
        }
        [HttpPost("onboardbyemail")]
        public async Task<ReturnSignature<CompanyProductDTO>> OnboardCompanyByEmail(OnboardByEmailPayload payload)
        {
            var result = await _service.OnboardCompanyByEmail(payload);
            return result;
        }

        [HttpPost("prepingdata")]
        public async Task<IActionResult> GetDataForPrep(List<string> gtins){
            var result = await _service.GetDataForPrep(gtins);
            return Ok(result);
        }

        [HttpPost("locations")]
        public async Task<IActionResult> GetLocations(LocationReg loc){
            return Ok(await _service.GetLocationInformation(loc.email));
        }

    }
}
