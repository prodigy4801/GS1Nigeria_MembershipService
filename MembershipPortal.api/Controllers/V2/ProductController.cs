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
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net.Http.Headers;
using MembershipPortal.service.Models;
using MembershipPortal.api.Helpers;

namespace MembershipPortal.api.Controllers.V2
{
    [Authorize]
    [Route("")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductSvc _service;
        private readonly IBrandInformationSvc _brandinformation_service;
        private readonly IGCPInformationSvc _gcpinformation_service;
        private readonly IBrickCategorySvc _brick_service;
        private readonly INetContentSvc _netcontent_service;
        private readonly IPackageLevelSvc _packagelevel_service;
        private readonly IPackagingTypeSvc _packagetype_service;
        private readonly ITargetMarketSvc _targetmarket_service;
        private readonly IProductTargetMarketSvc _productTargetMarket_service;
        private readonly IPharmaceuticalInformationSvc _pharmaceutical_service;
        private readonly IGTINRequestSvc _gtinRequestSvc;
        private readonly IGTINInformationSvc _gtinInformationSvc;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductSvc service, IBrandInformationSvc brandinformation_service, IProductTargetMarketSvc productTargetMarket_service,
            IGCPInformationSvc gcpinformation_service, IBrickCategorySvc brick_service, INetContentSvc netcontent_service, IPackageLevelSvc packagelevel_service,
            IPackagingTypeSvc packagetype_service, ITargetMarketSvc targetmarket_service, IPharmaceuticalInformationSvc pharmaceutical_service,
            IGTINRequestSvc gtinRequestSvc, IGTINInformationSvc gtinInformationSvc, IMapper mapper, ILogger<ProductController> logger)
        {
            this._service = service;
            this._brandinformation_service = brandinformation_service;
            this._gcpinformation_service = gcpinformation_service;
            this._brick_service = brick_service;
            this._netcontent_service = netcontent_service;
            this._packagelevel_service = packagelevel_service;
            this._packagetype_service = packagetype_service;
            this._targetmarket_service = targetmarket_service;
            this._mapper = mapper;
            this._logger = logger;
            this._productTargetMarket_service = productTargetMarket_service;
            this._pharmaceutical_service = pharmaceutical_service;
            this._gtinRequestSvc = gtinRequestSvc;
            this._gtinInformationSvc = gtinInformationSvc;
        }

        [AllowAnonymous]
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet(ApiRoutes.RProduct.GetAllDataTable)]
        public async Task<IActionResult> GetAllPagination([FromQuery] RecordPaginationModel pagination)
        {
            List<ProductTargetMarket> prdtTgtMkt = new List<ProductTargetMarket>();
            GenericResponseList<ProductTargetMarket> prdtTgtMktObj = new GenericResponseList<ProductTargetMarket>();
            try
            {
                int skip = (pagination.PageNumber - 1) * pagination.PageSize;
                int take = pagination.PageSize;
                var obj = await _service.GetAll(skip, take);
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var response = _mapper.Map<IEnumerable<ProductVM>>(obj.ReturnedObject);
                    foreach (var product in response)
                    {
                        prdtTgtMktObj = await _productTargetMarket_service.GetByProductRegistrationID(product.id, product.registrationid);
                        foreach (var tgtMkt in prdtTgtMktObj.ReturnedObject)
                        {
                            product.TargetMarketList.Add(tgtMkt.TargetMarket.name);
                        }
                    }
                    //prdtTgtMkt = prdtTgtMktObj.ReturnedObject.ToList();
                    return Ok(response);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }
        // GET: api/<BenefitProductController>
        [AllowAnonymous]
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet(ApiRoutes.RProduct.GetAll)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var obj = await _service.GetAll();
                if (obj.IsSuccess && obj.ReturnedObject.Count() >= 0)
                {
                    var response = _mapper.Map<IEnumerable<ProductVM>>(obj.ReturnedObject);
                    return Ok(response);
                }

                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // GET api/<BenefitController>/5
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet(ApiRoutes.RProduct.GetByID)]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var obj = await _service.GetByID(id);

                if (obj.IsSuccess && obj.ReturnedObject != null)
                {
                    var result = _mapper.Map<ProductVM>(obj.ReturnedObject);
                    return Ok(result);
                }
                return NotFound(obj.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        // GET api/<BenefitController>/5
        [HttpGet(ApiRoutes.RProduct.GetByRegistrationID)]
        public async Task<IActionResult> GetByRegistrationID(string registrationid)
        {
            ServiceResponseList<ProductVM> response = new ServiceResponseList<ProductVM>
            {
                ReturnedObject = new List<ProductVM>(),
                IsSuccess = false,
                Message = string.Empty
            };
            var obj = await _service.GetByRegistrationID(registrationid);
            response = _mapper.Map<ServiceResponseList<ProductVM>>(obj);
            if (obj.IsSuccess && obj.ReturnedObject != null)
            {
                //Load the target market and also pharmaceutical information information to the list
                if (response.ReturnedObject.Count() > 0)
                {
                    foreach (var product in response.ReturnedObject)
                    {
                        var productTargetMarket = await _productTargetMarket_service.GetByProductRegistrationID(product.id, product.registrationid);
                        if (productTargetMarket.ReturnedObject.Count() > 0)
                        {
                            product.TargetMarketList = productTargetMarket.ReturnedObject.Select(x => x.TargetMarket.name).ToList();
                        }
                        if (product.IsPharma)
                        {
                            var pharmaProduct = await _pharmaceutical_service.GetByProductID(product.id);
                            product.PharmaceuticalInformation = pharmaProduct.IsSuccess && pharmaProduct.ReturnedObject != null ? _mapper.Map<PharmaceuticalInformationVM>(pharmaProduct.ReturnedObject) : null;
                        }
                    }
                }
            }
            return Ok(response);
        }

        [HttpPost(ApiRoutes.RProduct.Create), DisableRequestSizeLimit]
        public async Task<IActionResult> Post([FromForm] ProductVM_CreateWithUploads req)
        {
            ServiceResponse<ProductVM> response = new ServiceResponse<ProductVM>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            if (!ModelState.IsValid)
            {
                var errors = string.Join("; ", ModelState.Values
                                    .SelectMany(x => x.Errors)
                                    .Select(x => x.ErrorMessage));
                response.Message = errors;
                return StatusCode(StatusCodes.Status200OK, response);
            }
            if (req.Product.IsPharma && req.PharmaceuticalInformation == null)
            {
                response.Message = "Healthcare properties cannot be empty. Complete your registration.";
                return StatusCode(StatusCodes.Status200OK, response);
            }
            var productModel = _mapper.Map<Product>(req.Product);
            productModel.targetmarket_id = String.Join(",", req.TargetMarketList);

            //getbrand by ID
            var brandInfoObj = await _brandinformation_service.GetByID(Convert.ToInt32(productModel.brandinformation_id));
            if (brandInfoObj.ReturnedObject == null)
            {
                response.Message = !string.IsNullOrEmpty(brandInfoObj.Message) ? brandInfoObj.Message : "Brand Information cannot be pulled from storage. Contact Technical team.";
                return StatusCode(StatusCodes.Status200OK, response);
            }
            if (string.IsNullOrEmpty(brandInfoObj.ReturnedObject.registrationid) && string.IsNullOrEmpty(brandInfoObj.ReturnedObject.brandname))
            {
                response.Message = "Brand Information cannot be verified. Contact Technical Team.";
                return StatusCode(StatusCodes.Status200OK, response);
            }
            productModel.brandname = brandInfoObj.ReturnedObject.brandname;
            productModel.registrationid = brandInfoObj.ReturnedObject.registrationid;

            var uploadedImage = _mapper.Map<ImageUploadModel>(req.ProductImageUpload);
            var obj = await _service.SaveProductWithImage(productModel, uploadedImage);
            response = _mapper.Map<ServiceResponse<ProductVM>>(obj);
            if (response.IsSuccess && response.ReturnedObject != null)
            {
                //Work on the Pharmaceutical Information
                if (req.Product.IsPharma)
                {
                    if (req.PharmaceuticalInformation != null)
                    {
                        var pharmaceuticalModel = _mapper.Map<PharmaceuticalInformation>(req.PharmaceuticalInformation);
                        pharmaceuticalModel.ProductID = response.ReturnedObject.id;
                        var pharmaceuticalObj = await _pharmaceutical_service.Save(pharmaceuticalModel);
                        if (!pharmaceuticalObj.IsSuccess)
                        {
                            response.Message += " Failed Listing Healthcare Information.";
                        }
                    }
                }
                //Load Target market table
                int targetmarketFailed = 0;
                var targetMarkets = obj.ReturnedObject.targetmarket_id.Split(",").ToList();
                foreach (string t_martket in targetMarkets)
                {
                    ProductTargetMarketVM_Create proTgtMktVM = new ProductTargetMarketVM_Create
                    {
                        product_id = response.ReturnedObject.id,
                        registrationid = response.ReturnedObject.registrationid,
                        targetmarket_id = Convert.ToInt32(t_martket),
                    };
                    var proTgtMktModel = _mapper.Map<ProductTargetMarket>(proTgtMktVM);
                    var producttargetmarketObj = await _productTargetMarket_service.Save(proTgtMktModel);
                    if (!producttargetmarketObj.IsSuccess) targetmarketFailed = targetmarketFailed + 1;
                }
                if (targetmarketFailed > 0) response.Message += " Target Market Information Failed Listing to storage.";

                var newObj = await _service.GetByID(response.ReturnedObject.id);

                if (newObj.IsSuccess && newObj.ReturnedObject != null)
                {
                    response.ReturnedObject = _mapper.Map<ProductVM>(newObj.ReturnedObject);
                    if (targetmarketFailed < 1)
                    {
                        foreach (var tgtmktID in targetMarkets)
                        {
                            var targetMarketObj = await _targetmarket_service.GetByID(Convert.ToInt32(tgtmktID));
                            response.ReturnedObject.TargetMarketList.Add(targetMarketObj.ReturnedObject.name);
                        }
                    }
                    return StatusCode(StatusCodes.Status200OK, response);
                }
            }
            return StatusCode(StatusCodes.Status200OK, response);
        }

        // POST api/<BenefitProductController>
        //[AllowAnonymous]
        [HttpPost(ApiRoutes.RProduct.UploadWithGTIN)]
        public async Task<IActionResult> UploadWithGTIN([FromBody] BulkProductWithGTIN_CR obj)
        {
            ExternalServiceResponseList<ProductVM> response = new ExternalServiceResponseList<ProductVM>
            {
                Status = 0,
                Message = new List<string>(),
                BadData = new List<string>(),
                ReturnedObject = null
            };
            List<Product> products = new List<Product>();
            List<Product> productsVerified = new List<Product>();

            Product productObj;
            //BrandInformation brandObj;
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
                    var errors = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                    response.Message.Add(errors);
                    return Ok(response);
                }

                var RemainingGTINs = await NumberOfGTINSRemaining(obj.registrationid);
                if (obj.ProductUploads.Count() > RemainingGTINs)
                {
                    response.Message.Add("GTINS left in your repository is not enough to process this request. Contact GS1 Nigeria.");
                    return Ok(response);
                }

                registrationid = obj.registrationid;
                foreach (ProductUpload upload in obj.ProductUploads)
                {
                    if (string.IsNullOrEmpty(upload.gtin))
                    {
                        response.Message.Add("Gtin cannot be empty. Review records");
                        continue;
                    }
                    if (upload.gtin.Trim().Length != 13)
                    {
                        response.Message.Add($"Gtin {upload.gtin} is not a valid GS1 GTIN. Lenght is not equal to 13.");
                        response.BadData.Add(upload.gtin);
                        continue;
                    }

                    string productCode = upload.gtin.Trim().Substring(0, 12);
                    string gtin_check_digit = upload.gtin.Trim().Substring(12, 1);
                    string gs1_check_digit = StringManipulation.CalculateChecksum(productCode);
                    if (gtin_check_digit != gs1_check_digit)
                    {
                        response.Message.Add($"Gtin {upload.gtin} is not a valid GS1 GTIN. Check digit is wrong");
                        response.BadData.Add(upload.gtin);
                        continue;
                    }

                    if (string.IsNullOrEmpty(upload.brandname))
                    {
                        response.Message.Add("Brand name cannot be empty. Review records");
                        response.BadData.Add(upload.gtin);
                        continue;
                    }

                    if (string.IsNullOrEmpty(upload.packagingtype))
                    {
                        response.Message.Add($"Packaging Type for GTIN {upload.gtin} cannot be empty.");
                        response.BadData.Add(upload.gtin);
                        continue;
                    }

                    var brandInformationSvc = await _brandinformation_service.GetByBrandName(upload.brandname);
                    if (brandInformationSvc.ReturnedObject == null)
                    {
                        //Create a new brand for this record
                        BrandInformationVM_Create newBrandInfoModel = new BrandInformationVM_Create()
                        {
                            brandname = upload.brandname,
                            isActive = true,
                            registrationid = registrationid
                        };
                        var brandInfo = _mapper.Map<BrandInformation>(newBrandInfoModel);
                        brandInformationSvc = await _brandinformation_service.Save(brandInfo);
                    }

                    var productExistStatus = await _service.ProductExist(upload.gtin, upload.brandname);
                    if (productExistStatus != null && productExistStatus.ReturnedObject)
                    {
                        response.Message.Add(productExistStatus.Message);
                        response.BadData.Add(upload.gtin);
                        continue;
                    }

                    productObj = new Product();
                    brickObj = new BrickCategory();
                    netcontentObj = new NetContent();
                    packagelevelObj = new PackageLevel();
                    packagetypeObj = new PackagingType();
                    targetMarketObj = new TargetMarket();

                    var brickSvc = await _brick_service.GetByBrickName(upload.category);
                    brickObj = brickSvc.IsSuccess && brickSvc.ReturnedObject != null ? brickSvc.ReturnedObject : null;

                    var netcontentSvc = await _netcontent_service.GetByContentName(upload.netcontent);
                    netcontentObj = netcontentSvc.IsSuccess && netcontentSvc.ReturnedObject != null ? netcontentSvc.ReturnedObject : null;

                    var packagelevelSvc = await _packagelevel_service.GetByLevelName(upload.packaginglevel);
                    packagelevelObj = packagelevelSvc.IsSuccess && packagelevelSvc.ReturnedObject != null ? packagelevelSvc.ReturnedObject : null;

                    var packagingtypeSvc = await _packagetype_service.GetByTypeName(upload.packagingtype);
                    packagetypeObj = packagingtypeSvc.IsSuccess && packagingtypeSvc.ReturnedObject != null ? packagingtypeSvc.ReturnedObject : null;

                    var targetmarketSvc = await _targetmarket_service.GetByMarketName(upload.targetmarket);
                    targetMarketObj = targetmarketSvc.IsSuccess && targetmarketSvc.ReturnedObject != null ? targetmarketSvc.ReturnedObject : null;

                    if (brandInformationSvc.ReturnedObject == null) response.Message.Add($"Cannot capture Brand Information for Brand Name {upload.brandname}.");

                    if (brickObj == null) response.Message.Add($"Cannot capture Brick Category for Brand Name {upload.brandname}.");

                    if (netcontentObj == null) response.Message.Add($"Cannot capture Netcontent Information for Brand Name {upload.brandname}.");

                    if (packagelevelObj == null) response.Message.Add($"Cannot capture Packaging Level Information for Brand Name {upload.brandname}.");

                    if (packagetypeObj == null) response.Message.Add($"Cannot capture Packaging Type Information for Brand Name {upload.brandname}.");

                    if (targetMarketObj == null) response.Message.Add($"Cannot capture Target Market Information for Brand Name {upload.brandname}.");

                    if (response.Message.Count() > 0) response.BadData.Add(upload.gtin);

                    productObj.allergeninfo = upload.allergeninformation;
                    productObj.brandname = upload.brandname;
                    productObj.brickcategory_id = brickObj != null ? brickObj.id : 0;
                    productObj.consumerfirstavailabilitydate = upload.availabilitydate;
                    productObj.directionofuse = upload.directionofuse;
                    productObj.grossweight = upload.grossweight;
                    productObj.gtin = upload.gtin;
                    productObj.ingredients = upload.ingredients;
                    productObj.lifespan = upload.lifespan;
                    productObj.lifespanunit = upload.lifespanunit;
                    productObj.marketingmessage = upload.marketingmessage;
                    productObj.nafdacnumber = upload.nafdacnumber;
                    productObj.netcontent_id = netcontentObj != null ? netcontentObj.id : 0;
                    productObj.netweight = upload.netweight;
                    productObj.packaginglevel_id = packagelevelObj != null ? packagelevelObj.id : 0;
                    productObj.packagingtype_id = packagetypeObj != null ? packagetypeObj.id : 0;
                    productObj.productdescription = upload.productdescription;
                    productObj.registrationid = registrationid;
                    productObj.storageinstruction = upload.storageinformation;
                    productObj.targetmarket_id = targetMarketObj != null ? targetMarketObj.id.ToString() : null;

                    products.Add(productObj);
                }

                if (response.Message.Count() < 1)
                {
                    if (products.Count() > 0)
                    {
                        var result = await _service.SaveProductList(products, registrationid);
                        response.Message.Add(result.Message);
                        if (result.IsSuccess)
                        {
                            response.ReturnedObject = _mapper.Map<List<ProductVM>>(result.ReturnedObject);
                            response.Status = 1;
                            _logger.LogInformation("Success: Create Product ", response);
                            return StatusCode(StatusCodes.Status200OK, response);
                        }
                    }
                    _logger.LogError("Failed: Create Product. ", response);
                    return StatusCode(StatusCodes.Status200OK, response);
                }

                return StatusCode(StatusCodes.Status200OK, response);
            }
            catch (Exception ex)
            {
                response.Message.Add(ex.Message);
                _logger.LogError("Failed: Create Product. " + ex);
                return StatusCode(StatusCodes.Status200OK, response);
            }

        }

        //[AllowAnonymous]
        [HttpPost(ApiRoutes.RProduct.UploadWithoutGTIN)]
        public async Task<IActionResult> UploadWithoutGTIN([FromBody] BulkProductWithoutGTIN_CR obj)
        {
            ExternalServiceResponseList<ProductVM> response = new ExternalServiceResponseList<ProductVM>
            {
                Status = 0,
                Message = new List<string>(),
                BadData = new List<string>(),
                ReturnedObject = null
            };
            List<Product> products = new List<Product>();
            List<Product> productsVerified = new List<Product>();

            Product productObj;
            //BrandInformation brandObj;
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
                    var errors = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                    response.Message.Add(errors);
                    return Ok(response);
                }

                var RemainingGTINs = await NumberOfGTINSRemaining(obj.registrationid);
                if (obj.ProductUploads.Count() > RemainingGTINs)
                {
                    response.Message.Add("GTINS left in your repository is not enough to process this request. Contact GS1 Nigeria.");
                    return Ok(response);
                }

                registrationid = obj.registrationid;
                foreach (ProductWithoutGTIN upload in obj.ProductUploads)
                {

                    var brandInformationSvc = await _brandinformation_service.GetByBrandName(upload.brandname);
                    if (brandInformationSvc.ReturnedObject == null)
                    {
                        //Create a new brand for this record
                        BrandInformationVM_Create newBrandInfoModel = new BrandInformationVM_Create()
                        {
                            brandname = upload.brandname,
                            isActive = true,
                            registrationid = registrationid
                        };
                        var brandInfo = _mapper.Map<BrandInformation>(newBrandInfoModel);
                        brandInformationSvc = await _brandinformation_service.Save(brandInfo);
                    }

                    productObj = new Product();
                    brickObj = new BrickCategory();
                    netcontentObj = new NetContent();
                    packagelevelObj = new PackageLevel();
                    packagetypeObj = new PackagingType();
                    targetMarketObj = new TargetMarket();

                    var brickSvc = await _brick_service.GetByBrickName(upload.category);
                    brickObj = brickSvc.IsSuccess && brickSvc.ReturnedObject != null ? brickSvc.ReturnedObject : null;

                    var netcontentSvc = await _netcontent_service.GetByContentName(upload.netcontent);
                    netcontentObj = netcontentSvc.IsSuccess && netcontentSvc.ReturnedObject != null ? netcontentSvc.ReturnedObject : null;

                    var packagelevelSvc = await _packagelevel_service.GetByLevelName(upload.packaginglevel);
                    packagelevelObj = packagelevelSvc.IsSuccess && packagelevelSvc.ReturnedObject != null ? packagelevelSvc.ReturnedObject : null;

                    var packagingtypeSvc = await _packagetype_service.GetByTypeName(upload.packagingtype);
                    packagetypeObj = packagingtypeSvc.IsSuccess && packagingtypeSvc.ReturnedObject != null ? packagingtypeSvc.ReturnedObject : null;

                    var targetmarketSvc = await _targetmarket_service.GetByMarketName(upload.targetmarket);
                    targetMarketObj = targetmarketSvc.IsSuccess && targetmarketSvc.ReturnedObject != null ? targetmarketSvc.ReturnedObject : null;

                    if (brandInformationSvc.ReturnedObject == null) response.Message.Add($"Cannot capture Brand Information for Brand Name {upload.brandname}.");

                    if (brickObj == null) response.Message.Add($"Cannot capture Brick Category for Brand Name {upload.brandname}.");

                    if (netcontentObj == null) response.Message.Add($"Cannot capture Netcontent Information for Brand Name {upload.brandname}.");

                    if (packagelevelObj == null) response.Message.Add($"Cannot capture Packaging Level Information for Brand Name {upload.brandname}.");

                    if (packagetypeObj == null) response.Message.Add($"Cannot capture Packaging Type Information for Brand Name {upload.brandname}.");

                    if (targetMarketObj == null) response.Message.Add($"Cannot capture Target Market Information for Brand Name {upload.brandname}.");

                    if (response.Message.Count() > 0) response.BadData.Add(brandInformationSvc.ReturnedObject.brandname);

                    productObj.allergeninfo = upload.allergeninformation;
                    productObj.brandname = upload.brandname;
                    productObj.brickcategory_id = brickObj != null ? brickObj.id : 0;
                    productObj.consumerfirstavailabilitydate = upload.availabilitydate;
                    productObj.directionofuse = upload.directionofuse;
                    productObj.grossweight = upload.grossweight;
                    productObj.ingredients = upload.ingredients;
                    productObj.lifespan = upload.lifespan;
                    productObj.lifespanunit = upload.lifespanunit;
                    productObj.marketingmessage = upload.marketingmessage;
                    productObj.nafdacnumber = upload.nafdacnumber;
                    productObj.netcontent_id = netcontentObj != null ? netcontentObj.id : 0;
                    productObj.netweight = upload.netweight;
                    productObj.packaginglevel_id = packagelevelObj != null ? packagelevelObj.id : 0;
                    productObj.packagingtype_id = packagetypeObj != null ? packagetypeObj.id : 0;
                    productObj.productdescription = upload.productdescription;
                    productObj.registrationid = registrationid;
                    productObj.storageinstruction = upload.storageinformation;
                    productObj.targetmarket_id = targetMarketObj != null ? targetMarketObj.id.ToString() : null;

                    products.Add(productObj);
                }

                if (response.Message.Count() < 1)
                {
                    if (products.Count() > 0)
                    {
                        var result = await _service.SaveProductListWithoutGTIN(products, registrationid);
                        response.Message = result.Message;
                        if (result.IsSuccess)
                        {
                            response.ReturnedObject = _mapper.Map<List<ProductVM>>(result.ReturnedObject);
                            response.Status = 1;
                            _logger.LogInformation("Success: Create Product ", response);
                            return StatusCode(StatusCodes.Status200OK, response);
                        }
                    }
                    _logger.LogError("Failed: Create Product. ", response);
                    return StatusCode(StatusCodes.Status200OK, response);
                }

                return StatusCode(StatusCodes.Status200OK, response);
            }
            catch (Exception ex)
            {
                response.Message.Add(ex.Message);
                _logger.LogError("Failed: Create Product. " + ex);
                return StatusCode(StatusCodes.Status200OK, response);
            }

        }

        //[AllowAnonymous]
        [HttpPost(ApiRoutes.RProduct.Update), DisableRequestSizeLimit]
        public async Task<IActionResult> ProductUpdate([FromForm] ProductVM_UpdateWithUploads request)
        {
            ServiceResponse<ProductVM> response = new ServiceResponse<ProductVM>
            {
                IsSuccess = false,
                Message = string.Empty,
                ReturnedObject = null
            };
            GenericResponse<PharmaceuticalInformation> pharmaProductObj = new GenericResponse<PharmaceuticalInformation>();

            if (!ModelState.IsValid)
            {
                var errors = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));
                response.Message = errors;
                return BadRequest(response);
            }
            var newObj = await _service.GetByProdRegID(request.productID, request.registrationid);
            if (!newObj.IsSuccess)
            {
                response.Message = newObj.Message;
                return StatusCode(StatusCodes.Status200OK, response);
            }
            if (newObj.ReturnedObject == null)
            {
                response.Message = "Failed to retrieve Product Information from storage.";
                return StatusCode(StatusCodes.Status200OK, response);
            }

            newObj.ReturnedObject.netcontent_id = request.Product.netcontent_id;
            newObj.ReturnedObject.packagingtype_id = request.Product.packagingtype_id;
            //newObj.ReturnedObject.productdescription = request.Product.productdescription;
            newObj.ReturnedObject.marketingmessage = request.Product.marketingmessage;
            newObj.ReturnedObject.consumerfirstavailabilitydate = request.Product.consumerfirstavailabilitydate;
            newObj.ReturnedObject.netweight = request.Product.netweight;
            newObj.ReturnedObject.grossweight = request.Product.grossweight;
            newObj.ReturnedObject.brickcategory_id = request.Product.brickcategory_id;
            newObj.ReturnedObject.ingredients = request.Product.ingredients;
            newObj.ReturnedObject.allergeninfo = request.Product.allergeninfo;
            newObj.ReturnedObject.storageinstruction = request.Product.storageinstruction;
            newObj.ReturnedObject.directionofuse = request.Product.directionofuse;
            newObj.ReturnedObject.lifespan = request.Product.lifespan;
            newObj.ReturnedObject.lifespanunit = request.Product.lifespanunit;
            newObj.ReturnedObject.packaginglevel_id = request.Product.packaginglevel_id;

            if (newObj.ReturnedObject.IsPharma)
            {
                if (request.PharmaProduct != null)
                {

                    pharmaProductObj = await _pharmaceutical_service.GetByProductID(request.productID);
                    if (pharmaProductObj.IsSuccess & pharmaProductObj.ReturnedObject != null)
                    {
                        pharmaProductObj.ReturnedObject.ActiveIngredient = !string.IsNullOrEmpty(request.PharmaProduct.ActiveIngredient) ? request.PharmaProduct.ActiveIngredient : pharmaProductObj.ReturnedObject.ActiveIngredient;
                        pharmaProductObj.ReturnedObject.ATCCode = !string.IsNullOrEmpty(request.PharmaProduct.ATCCode) ? request.PharmaProduct.ATCCode : pharmaProductObj.ReturnedObject.ATCCode;
                        pharmaProductObj.ReturnedObject.DirectionOfUse = !string.IsNullOrEmpty(request.PharmaProduct.DirectionOfUse) ? request.PharmaProduct.DirectionOfUse : pharmaProductObj.ReturnedObject.DirectionOfUse;
                        pharmaProductObj.ReturnedObject.FunctionalName = !string.IsNullOrEmpty(request.PharmaProduct.FunctionalName) ? request.PharmaProduct.FunctionalName : pharmaProductObj.ReturnedObject.FunctionalName;
                        pharmaProductObj.ReturnedObject.GenericName = !string.IsNullOrEmpty(request.PharmaProduct.GenericName) ? request.PharmaProduct.GenericName : pharmaProductObj.ReturnedObject.GenericName;
                        pharmaProductObj.ReturnedObject.Manufacturer = !string.IsNullOrEmpty(request.PharmaProduct.Manufacturer) ? request.PharmaProduct.Manufacturer : pharmaProductObj.ReturnedObject.Manufacturer;
                        pharmaProductObj.ReturnedObject.ManufacturerAddress = !string.IsNullOrEmpty(request.PharmaProduct.ManufacturerAddress) ? request.PharmaProduct.ManufacturerAddress : pharmaProductObj.ReturnedObject.ManufacturerAddress;
                        pharmaProductObj.ReturnedObject.PackSize = !string.IsNullOrEmpty(request.PharmaProduct.PackSize) ? request.PharmaProduct.PackSize : pharmaProductObj.ReturnedObject.PackSize;
                        pharmaProductObj.ReturnedObject.PrimaryPackagingMaterial = !string.IsNullOrEmpty(request.PharmaProduct.PrimaryPackagingMaterial) ? request.PharmaProduct.PrimaryPackagingMaterial : pharmaProductObj.ReturnedObject.PrimaryPackagingMaterial;
                        pharmaProductObj.ReturnedObject.ProductForm = !string.IsNullOrEmpty(request.PharmaProduct.ProductForm) ? request.PharmaProduct.ProductForm : pharmaProductObj.ReturnedObject.ProductForm;
                        pharmaProductObj.ReturnedObject.Quantity = !string.IsNullOrEmpty(request.PharmaProduct.Quantity) ? request.PharmaProduct.Quantity : pharmaProductObj.ReturnedObject.Quantity;
                        pharmaProductObj.ReturnedObject.RouteOfAdministration = !string.IsNullOrEmpty(request.PharmaProduct.RouteOfAdministration) ? request.PharmaProduct.RouteOfAdministration : pharmaProductObj.ReturnedObject.RouteOfAdministration;
                        pharmaProductObj.ReturnedObject.ShelfLife = !string.IsNullOrEmpty(request.PharmaProduct.ShelfLife) ? request.PharmaProduct.ShelfLife : pharmaProductObj.ReturnedObject.ShelfLife;
                        pharmaProductObj.ReturnedObject.Strength = !string.IsNullOrEmpty(request.PharmaProduct.Strength) ? request.PharmaProduct.Strength : pharmaProductObj.ReturnedObject.Strength;
                        pharmaProductObj.ReturnedObject.TradeItemDescription = !string.IsNullOrEmpty(request.PharmaProduct.TradeItemDescription) ? request.PharmaProduct.TradeItemDescription : pharmaProductObj.ReturnedObject.TradeItemDescription;
                    }
                }
            }

            var uploadedImage = _mapper.Map<ImageUploadModel>(request.ProductImageUpload);
            var result = await _service.SaveUpdateWithImage(newObj.ReturnedObject, request.TargetMarketList, uploadedImage, pharmaProductObj.ReturnedObject);
            response = _mapper.Map<ServiceResponse<ProductVM>>(result);
            if (response.ReturnedObject.IsPharma)
            {
                var pharmaProduct = await _pharmaceutical_service.GetByProductID(response.ReturnedObject.id);
                response.ReturnedObject.PharmaceuticalInformation = pharmaProduct.IsSuccess && pharmaProduct.ReturnedObject != null ? _mapper.Map<PharmaceuticalInformationVM>(pharmaProduct.ReturnedObject) : null;
            }
            return StatusCode(StatusCodes.Status200OK, response);
        }

        private async Task<long> NumberOfGTINSRemaining(string registrationID)
        {
            long totalGTINsLeft = 0;
            try
            {
                bool isGCPPending = false;
                long totalGTINsRequested = 0;
                long totalGTINsUsed = 0;
                //long totalGTINsLeft = 0;

                var gtinRequestObj = await _gtinRequestSvc.GetListByRegistrationID(registrationID);
                if (gtinRequestObj.IsSuccess && gtinRequestObj.ReturnedObject.Count() > 0)
                {
                    totalGTINsRequested = gtinRequestObj.ReturnedObject.Where(x => x.isapproved && x.isgcpassigned).Select(x => x.gtincount).Sum();
                }
                //totalGTINsRequested = gtinRequestObj != null && gtinRequestObj.ReturnedObject.Count() > 0 ? gtinRequestObj.ReturnedObject.Select(x => x.gtincount).Sum() : 0;

                var gtinInformationObj = await _gtinInformationSvc.CountListedGtinByRegID(registrationID);
                totalGTINsUsed = gtinInformationObj != null && gtinInformationObj.ReturnedObject > 0 && totalGTINsRequested > 0 ? gtinInformationObj.ReturnedObject : 0;

                totalGTINsLeft = totalGTINsRequested - totalGTINsUsed;
            }
            catch (Exception ex)
            {
                totalGTINsLeft = 0;
            }
            return totalGTINsLeft;
        }
    }
}
