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
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductSvc _service;
        private readonly IBrickCategorySvc _brick_service;
        private readonly INetContentSvc _netcontent_service;
        private readonly IPackageLevelSvc _packagelevel_service;
        private readonly IPackagingTypeSvc _packagetype_service;
        private readonly ITargetMarketSvc _targetmarket_service;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductSvc service, IBrickCategorySvc brick_service, INetContentSvc netcontent_service, IPackageLevelSvc packagelevel_service, IPackagingTypeSvc packagetype_service, ITargetMarketSvc targetmarket_service, IMapper mapper, ILogger<ProductController> logger)
        {
            this._service = service;
            this._brick_service = brick_service;
            this._netcontent_service = netcontent_service;
            this._packagelevel_service = packagelevel_service;
            this._packagetype_service = packagetype_service;
            this._targetmarket_service = targetmarket_service;
            this._mapper = mapper;
            this._logger = logger;
        }
        // GET: api/<BenefitProductController>
        [HttpGet(ApiRoutes.RProduct.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj != null && obj.Count() >= 0)
                {
                    _logger.LogInformation("Success: Get All GLN records");
                    var result = _mapper.Map<IEnumerable<ProductVM>>(obj);
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
        [HttpGet(ApiRoutes.RProduct.GetByID)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var data = await _service.GetByID(id);

                if (data != null)
                {
                    _logger.LogInformation("Success: Get Product with id " + id);
                    var obj = _mapper.Map<ProductVM>(data);
                    return Ok(obj);
                }

                _logger.LogInformation("NULL: Get Product with id " + id);
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Get Product with id with error " + ex);
                return null;
            }
        }

        // POST api/<BenefitProductController>
        [HttpPost(ApiRoutes.RProduct.Create)]
        public async Task<IActionResult> Post([FromBody] ProductVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create Product ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    Product data = _mapper.Map<Product>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create Product ", result);
                        var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        var locationUrl = baseUrl + "/" + ApiRoutes.RProduct.GetByID.Replace("{id}", data.id.ToString());
                        return Created(locationUrl, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create Product ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create Product " + ex);
                return null;
            }

        }

        // POST api/<BenefitProductController>
        [HttpPost(ApiRoutes.RProduct.UploadCreate)]
        public async Task<IActionResult> PostUpload([FromBody] ProductUploadsVM_CRU obj)
        {
            List<Product> products = new List<Product>();

            Product productObj;
            BrickCategory brickObj;
            NetContent netcontentObj;
            PackageLevel packagelevelObj;
            PackagingType packagetypeObj;
            TargetMarket targetMarketObj;
            string registrationid = string.Empty;

            try
            {
                if (!ModelState.IsValid)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Create Product ", errors);
                    return BadRequest(errors);
                }
                else
                {
                    registrationid = obj.registrationid;
                    foreach (ProductUpload upload in obj.ProductUploads)
                    {
                        productObj = new Product();
                        brickObj = new BrickCategory();
                        netcontentObj = new NetContent();
                        packagelevelObj = new PackageLevel();
                        packagetypeObj = new PackagingType();
                        targetMarketObj = new TargetMarket();

                        brickObj = await _brick_service.GetByBrickName(upload.category);
                        netcontentObj = await _netcontent_service.GetByNetContentName(upload.netcontent);
                        packagelevelObj = await _packagelevel_service.GetByPackageLevelName(upload.packaginglevel);
                        packagetypeObj = await _packagetype_service.GetByPackagingTypeName(upload.packagingtype);
                        targetMarketObj = await _targetmarket_service.GetByTargetMarketName(upload.targetmarket);

                        productObj.allergeninfo = upload.allergeninformation;
                        productObj.brandname = upload.brandname;
                        productObj.brickcategory_id = brickObj.id;
                        productObj.consumerfirstavailabilitydate = upload.availabilitydate;
                        productObj.directionofuse = upload.directionofuse;
                        productObj.grossweight = upload.grossweight;
                        productObj.gtin = upload.gtin;
                        productObj.ingredients = upload.ingredients;
                        productObj.lifespan = upload.lifespan;
                        productObj.lifespanunit = upload.lifespanunit;
                        productObj.marketingmessage = upload.marketingmessage;
                        productObj.nafdacnumber = upload.nafdacnumber;
                        productObj.netcontent_id = netcontentObj.id;
                        productObj.netweight = upload.netweight;
                        productObj.packaginglevel_id = packagelevelObj.id;
                        productObj.packagingtype_id = packagetypeObj.id;
                        productObj.productdescription = upload.productdescription;
                        productObj.registrationid = registrationid;
                        productObj.storageinstruction = upload.storageinformation;
                        productObj.targetmarket_id = targetMarketObj.id;

                        products.Add(productObj);
                    }

                    var result = await _service.SaveProductList(products);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Create Product ", result);
                        //var baseUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
                        //var locationUrl = baseUrl + "/" + ApiRoutes.RProduct.GetByID.Replace("{id}", result.Data.Add.id.ToString());
                        return StatusCode(StatusCodes.Status200OK, result);
                    }
                    else
                    {
                        _logger.LogError("Failed: Create Product ", result);
                        return StatusCode(StatusCodes.Status404NotFound, result);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Create Product " + ex);
                return null;
            }

        }

        // PUT api/<BenefitProductController>/5
        [HttpPut(ApiRoutes.RProduct.Update)]
        public async Task<IActionResult> Put([FromBody] ProductVM_CRU obj)
        {
            try
            {
                if (!ModelState.IsValid && obj.id == 0)
                {
                    var errors = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
                    _logger.LogInformation("Failed: Update Product ", errors);
                    return BadRequest();
                }
                else
                {
                    var data = _mapper.Map<Product>(obj);
                    var result = await _service.Save(data);
                    if (result.IsSuccess)
                    {
                        _logger.LogInformation("Success: Update Product ", result);
                        return Ok(result);
                    }

                    else
                    {
                        _logger.LogError("Failed: Update Product ", result);
                        return StatusCode(StatusCodes.Status500InternalServerError, result);
                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed: Update Product " + ex);
                return null;
            }
        }
    }
}
