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
using GS1NGBarcodeLib;
using System.IO;
using Microsoft.AspNetCore.StaticFiles;

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
        //[AllowAnonymous]
        [HttpGet(ApiRoutes.RImageBank.GetAll)]
        [ApiExplorerSettings(IgnoreApi = true)]
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
        //[AllowAnonymous]
        [HttpGet(ApiRoutes.RImageBank.GetByID)]
        [ApiExplorerSettings(IgnoreApi = true)]
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
            ServiceResponse<ImageBankVM> response = new ServiceResponse<ImageBankVM>
            {
                ReturnedObject = new ImageBankVM(),
                IsSuccess = true,
                Message = string.Empty
            };
            var obj = await _service.GetByRegistrationID(registrationid);
            response = _mapper.Map<ServiceResponse<ImageBankVM>>(obj);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.RImageBank.GenerateBarcode)]
        public async Task<IActionResult> GenerateBarcode(BarcodeGeneratorModel image)
        {
            ServiceResponse<BarcodeResponseModel> result = new ServiceResponse<BarcodeResponseModel>
            {
                ReturnedObject = new BarcodeResponseModel(),
                IsSuccess = true,
                Message = "Successfully Generated Image"
            };
            try
            {
                var verifyUserBarcodeImage = await _service.ProcessGenerationOfBarcodeImage(image.gtin, image.registrationId);
                if(!verifyUserBarcodeImage.IsSuccess)
                {
                    result.IsSuccess = false;
                    result.Message = verifyUserBarcodeImage.Message;
                    result.ReturnedObject.DisplayImageLink = string.Empty;
                    result.ReturnedObject.MainImageLink = string.Empty;

                    return StatusCode(StatusCodes.Status200OK, result);
                }

                BarcodeResponseModel response = new BarcodeResponseModel();
                DirectoryInfo di = new DirectoryInfo("barcodeImages");
                FileInfo[] mainFile = di.GetFiles($"{image.gtin}.{GetImageExtension(image.format)}");
                FileInfo[] displayFile = di.GetFiles($"{image.gtin}.{GetImageExtension(BarcodeUtil.BarcodeFormat.PNG)}");
                if (mainFile.Length == 0) BarcodeUtil.GenerateBarcode(image.gtin, image.format);
                if (image.format != 0)
                {
                    if (displayFile.Length == 0) BarcodeUtil.GenerateBarcode(image.gtin, 0);
                }

                var baseUri = $"{Request.Scheme}://{Request.Host}";
                var pathFile = "barcodeImages";
                var fileNameDisplay = $"{pathFile}/{image.gtin}.{GetImageExtension(BarcodeUtil.BarcodeFormat.PNG)}";
                var fileNameMain = $"{pathFile}/{image.gtin}.{GetImageExtension(image.format)}";
                response.DisplayImageLink = $"{baseUri}/{fileNameDisplay}";
                response.MainImageLink = $"{baseUri}/{fileNameMain}";

                result.ReturnedObject = response;
                result.Message = verifyUserBarcodeImage.Message;
                result.IsSuccess = true;

                return StatusCode(StatusCodes.Status200OK, result);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpGet(ApiRoutes.RImageBank.DownloadBarcode)]
        public async Task<IActionResult> DocumentDownload([FromQuery] string gtin)
        {
            try
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "barcodeImages", $"{gtin}.{GetImageExtension(BarcodeUtil.BarcodeFormat.PNG)}");
                if (!System.IO.File.Exists(filePath)) return StatusCode(StatusCodes.Status200OK, "File to download does not exist in the server.");
                var memory = new MemoryStream();
                await using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    await stream.CopyToAsync(memory);
                }
                memory.Position = 0;
                string fileName = Path.GetFileName(filePath);
                return File(memory, GetContentType(filePath), fileName);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, ex.Message);
            }
        }

        private string GetImageExtension(BarcodeUtil.BarcodeFormat extensionValue)
        {
            string extension = string.Empty;
            switch (extensionValue)
            {
                case BarcodeUtil.BarcodeFormat.EMF:
                    extension = "emf";
                    break;
                case BarcodeUtil.BarcodeFormat.PDF:
                    extension = "pdf";
                    break;
                case BarcodeUtil.BarcodeFormat.WMF:
                    extension = "wmf";
                    break;
                default:
                    extension = "png";
                    break;
            }

            return extension;
        }

        private string GetContentType(string path)
        {
            var provider = new FileExtensionContentTypeProvider();
            string contentType;

            if (!provider.TryGetContentType(path, out contentType))
            {
                contentType = "application/octet-stream";
            }

            return contentType;
        }

        // POST api/<BenefitImageBankController>
        //[AllowAnonymous]
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

        //[AllowAnonymous]
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
