using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;
using MembershipPortal.service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.service.Concrete
{
    public class ProductSvc : IProductSvc
    {
        private readonly IUnitOfWork _uow;
        private readonly ApplicationDBContext _context;
        private string[] _includes = { "BrickCategory", "NetContent", "PackagingType", "PackageLevel", "BrandInformation" };

        public ProductSvc(IUnitOfWork uow, ApplicationDBContext context)
        {
            _uow = uow;
            _context = context;
        }

        public async Task<GenericResponseList<Product>> GetAll()
        {
            try
            {
                var records = await _uow.ProductRP.GetBy(null, y => y.OrderByDescending(y => y.id), null, null, _includes);
                return new GenericResponseList<Product> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<Product> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<Product>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.ProductRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<Product> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<Product> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<Product>> GetByID(int id)
        {
            try
            {
                var record = await _uow.ProductRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<Product> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<Product> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<Product>> GetByProdRegID(int prodId, string regId)
        {
            try
            {
                var record = await _uow.ProductRP.GetByFirstOrDefault(x => x.id == prodId && x.registrationid == regId, _includes);
                return new GenericResponse<Product> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<Product> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<Product>> GetByRegistrationID(string regId)
        {
            try
            {
                var record = await _uow.ProductRP.GetBy(x => x.registrationid == regId, x => x.OrderByDescending(y => y.id), null, null, _includes); ;
                return new GenericResponseList<Product> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<Product> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponse<Product>> Remove(Product obj)
        {

            try
            {
                _uow.ProductRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<Product> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<Product> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<Product> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<Product>> Remove(int id)
        {

            try
            {
                var obj = _uow.ProductRP.GetById(id);
                _uow.ProductRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<Product> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<Product> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<Product> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<Product>> SaveProductWithImage(Product profile, ImageUploadModel uploads)
        {
            if (profile.id == 0)
            {
                profile.createddate = DateTime.UtcNow;
                return await Add(profile, uploads);
            }
            else
            {
                profile.modifieddate = DateTime.UtcNow;
                return await Update(profile.id, profile);
            }
        }

        public async Task<GenericResponse<bool>> ProductExist(string gtin, string brandName)
        {
            GenericResponse<bool> response = new GenericResponse<bool>
            {
                ReturnedObject = false,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (await _uow.ProductRP.AnyAsync(x => x.gtin == gtin))
                {
                    response.Message = $"GTIN already exist for Brand Name {brandName}.";
                    response.ReturnedObject = true;
                }
            }
            catch (Exception ex)
            {

            }
            return response;
        }
        public async Task<GenericResponseList<Product>> SaveProductList(IEnumerable<Product> products, string registrationid)
        {
            List<Product> mainProductStore = new List<Product>();
            List<GTINInformation> mainGTINInformationStore = new List<GTINInformation>();
            try
            {
                var gcpInformationList = await _uow.GCPInformationRP.GetBy(x => x.RegistrationID == registrationid);
                //var gcpInformationList = await _context.GCPInformations.Where(x => x.RegistrationID == registrationid).ToListAsync();
                if (gcpInformationList == null || gcpInformationList.Count() < 1) return new GenericResponseList<Product> { ReturnedObject = null, IsSuccess = false, Message = "Company Prefix has not been generated. Contact GS1 Nigeria Admin." };

                IEnumerable<GTINInformation> gtinInformationList = new List<GTINInformation>();
                GCPInformation gcpInformationObj = new GCPInformation();
                var companyPrefix = string.Empty;
                int totalGTINGenerated = 0;
                foreach (var gcp in gcpInformationList)
                {
                    if (!gcp.Active) continue;
                    gtinInformationList = await _uow.GTINInformationRP.GetBy(x => x.registrationid == registrationid && x.companyprefix == gcp.CompanyPrefix);
                    //gtinInformationList = await _context.GTINInformations.Where(x => x.registrationid == registrationid && x.companyprefix == gcp.CompanyPrefix).ToListAsync();
                    totalGTINGenerated = gtinInformationList.Count();
                    if (totalGTINGenerated < gcp.GtinCount)
                    {
                        gcpInformationObj = gcp;
                        companyPrefix = gcp.CompanyPrefix.Trim();
                        break;
                    }
                }
                if (string.IsNullOrEmpty(companyPrefix)) return new GenericResponseList<Product> { ReturnedObject = null, IsSuccess = false, Message = "Company Prefix is inactive or your assigned GTINs has been exhausted. Contact GS1 Nigeria Admin." };

                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        foreach (Product product in products)
                        {
                            GTINInformation gtinObj = new GTINInformation
                            {
                                gtin = product.gtin,
                                registrationid = product.registrationid,
                                checksum = product.gtin.Trim().Substring(12, 1),
                                companyprefix = companyPrefix,
                                createddate = DateTime.Now,
                                productcode = product.gtin.Trim().Substring(0, 12)
                            };
                            product.dateoflisting = DateTime.UtcNow;
                            product.createddate = DateTime.UtcNow;
                            product.iscompleted = ProductCompleteStatus(product);

                            //store all entity in a separate container
                            mainGTINInformationStore.Add(gtinObj);
                            mainProductStore.Add(product);
                        }

                        if (mainGTINInformationStore.Count > 0)
                        {
                            _context.GTINInformations.AddRange(mainGTINInformationStore);
                        }
                        if (mainProductStore.Count > 0)
                        {
                            _context.Products.AddRange(mainProductStore);
                            await _context.SaveChangesAsync();
                            await transaction.CommitAsync();
                            return new GenericResponseList<Product> { ReturnedObject = mainProductStore, IsSuccess = true, Message = "Successfully Saved Product(s) to Storage." };
                        }
                        return new GenericResponseList<Product> { ReturnedObject = null, IsSuccess = false, Message = "Could not retrieve product list." };
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        return new GenericResponseList<Product> { ReturnedObject = null, IsSuccess = false, Message = ex.Message };
                    }
                }
            }
            catch (Exception ex)
            {
                return new GenericResponseList<Product> { ReturnedObject = null, IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<GenericServiceResponseList<Product>> SaveProductListWithoutGTIN(IEnumerable<Product> products, string registrationid)
        {
            var response = new GenericServiceResponseList<Product>()
            {
                BadData = new List<string>(),
                IsSuccess = false,
                Message = new List<string>(),
                ReturnedObject = null
            };
            List<Product> mainProductStore = new List<Product>();
            List<GTINInformation> mainGTINInformationStore = new List<GTINInformation>();
            try
            {
                var gcpInformationList = await _uow.GCPInformationRP.GetBy(x => x.RegistrationID == registrationid);
                //var gcpInformationList = await _context.GCPInformations.Where(x => x.RegistrationID == registrationid).ToListAsync();
                if (gcpInformationList == null || gcpInformationList.Count() < 1)
                {
                    response.Message.Add("Company Prefix has not been generated. Contact GS1 Nigeria Admin.");
                    return response;
                } 

                IEnumerable<GTINInformation> gtinInformationList = new List<GTINInformation>();
                GCPInformation gcpInformationObj = new GCPInformation();
                var companyPrefix = string.Empty;
                int totalGTINGenerated = 0;
                foreach (var gcp in gcpInformationList)
                {
                    if (!gcp.Active) continue;
                    gtinInformationList = await _uow.GTINInformationRP.GetBy(x => x.registrationid == registrationid && x.companyprefix == gcp.CompanyPrefix);
                    //gtinInformationList = await _context.GTINInformations.Where(x => x.registrationid == registrationid && x.companyprefix == gcp.CompanyPrefix).ToListAsync();
                    totalGTINGenerated = gtinInformationList.Count();
                    if (totalGTINGenerated < gcp.GtinCount)
                    {
                        gcpInformationObj = gcp;
                        companyPrefix = gcp.CompanyPrefix.Trim();
                        break;
                    }
                }
                if (string.IsNullOrEmpty(companyPrefix))
                {
                    response.Message.Add("Company Prefix is inactive or your assigned GTINs has been exhausted. Contact GS1 Nigeria Admin.");
                    return response;
                }

                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        List<Product> failedGTINGeneratedList = new List<Product>();
                        List<Product> succesfulGTINGeneratedList = new List<Product>();
                        foreach (Product product in products)
                        {
                            string generatedProductCode = GenerateProductCode(gcpInformationObj, gtinInformationList, registrationid);
                            if (string.IsNullOrEmpty(generatedProductCode) || generatedProductCode.Length != 12)
                            {
                                response.Message.Add("Your GTINs seems to have been exhausted. Kindly check if you still have GCP allocated!");
                                return response;
                            }
                            string generatedCheckSum = CalculateChecksum(generatedProductCode);
                            string generatedGTIN = generatedProductCode + generatedCheckSum;

                            product.gtin = generatedGTIN;
                            succesfulGTINGeneratedList.Add(product);
                        }

                        foreach (Product product in succesfulGTINGeneratedList)
                        {
                            GTINInformation gtinObj = new GTINInformation
                            {
                                gtin = product.gtin,
                                registrationid = product.registrationid,
                                checksum = product.gtin.Trim().Substring(12, 1),
                                companyprefix = companyPrefix,
                                createddate = DateTime.Now,
                                productcode = product.gtin.Trim().Substring(0, 12)
                            };
                            product.dateoflisting = DateTime.UtcNow;
                            product.createddate = DateTime.UtcNow;
                            product.iscompleted = ProductCompleteStatus(product);

                            //store all entity in a separate container
                            mainGTINInformationStore.Add(gtinObj);
                            mainProductStore.Add(product);
                        }

                        if (mainGTINInformationStore.Count > 0)
                        {
                            _context.GTINInformations.AddRange(mainGTINInformationStore);
                        }
                        if (mainProductStore.Count > 0)
                        {
                            _context.Products.AddRange(mainProductStore);
                            await _context.SaveChangesAsync();
                            await transaction.CommitAsync();
                            response.Message.Add("Successfully Saved Product(s) to Storage.");
                            response.IsSuccess = true;
                            response.ReturnedObject = mainProductStore;
                            return response;
                        }
                        response.Message.Add("Could not retrieve product list.");
                        return response;
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        response.Message.Add(ex.Message);
                        return response;
                    }
                }
            }
            catch (Exception ex)
            {
                response.Message.Add(ex.Message);
                return response;
            }
        }

        private async Task<GenericResponse<Product>> Add(Product profile, ImageUploadModel imageFile)
        {
            try
            {
                //Check if GCP has been asigned to the user
                var gcpInformationList = await _uow.GCPInformationRP.GetBy(x => x.RegistrationID == profile.registrationid);
                if (gcpInformationList == null || gcpInformationList.Count() < 1) return new GenericResponse<Product> { ReturnedObject = null, IsSuccess = false, Message = "Company Prefix has not been generated. Contact GS1 Nigeria Admin." };

                IEnumerable<GTINInformation> gtinInformationList = new List<GTINInformation>();
                GCPInformation gcpInformationObj = new GCPInformation();
                var companyPrefix = string.Empty;
                int totalGTINGenerated = 0;
                foreach (var gcp in gcpInformationList)
                {
                    if (!gcp.Active) continue;
                    gtinInformationList = await _uow.GTINInformationRP.GetBy(x => x.registrationid == profile.registrationid && x.companyprefix == gcp.CompanyPrefix);
                    totalGTINGenerated = gtinInformationList.Count();
                    if (totalGTINGenerated < gcp.GtinCount)
                    {
                        gcpInformationObj = gcp;
                        companyPrefix = gcp.CompanyPrefix.Trim();
                        break;
                    }
                }
                if (string.IsNullOrEmpty(companyPrefix)) return new GenericResponse<Product> { ReturnedObject = null, IsSuccess = false, Message = "Company Prefix is inactive or your assigned GTINs has been exhausted. Contact GS1 Nigeria Admin." };

                //Generate GTIN then store in the GTINInformation table. To generate a GTIN we need to:
                //1. to generate the productcode.
                string generatedProductCode = GenerateProductCode(gcpInformationObj, gtinInformationList, profile.registrationid);
                if (string.IsNullOrEmpty(generatedProductCode) || generatedProductCode.Length != 12) return new GenericResponse<Product> { ReturnedObject = null, IsSuccess = false, Message = "Your GTINs seems to have been exhausted. Kindly check if you still have GCP allocated!" };

                //2. to generate the checksum
                string generatedCheckSum = CalculateChecksum(generatedProductCode);

                //Hence the GTIN is a combination of the productcode and the checksum
                string generatedGTIN = generatedProductCode + generatedCheckSum;
                GTINInformation gtinObj = new GTINInformation
                {
                    gtin = generatedGTIN,
                    registrationid = profile.registrationid,
                    checksum = generatedCheckSum,
                    companyprefix = companyPrefix,
                    createddate = DateTime.Now,
                    productcode = generatedProductCode
                };
                //Save the information in the GTINInformation table
                _uow.GTINInformationRP.Add(gtinObj);

                //Save information to Product table
                profile.gtin = generatedGTIN;
                profile.dateoflisting = DateTime.Now;
                //Upload Images
                if (imageFile != null)
                {
                    var ImagePath = await StoreImageTODirectory(imageFile, gtinObj.registrationid, gtinObj.gtin);
                    profile.hasimage = (ImagePath.Front != null || ImagePath.Back != null || ImagePath.Left != null || ImagePath.Right != null || ImagePath.Other != null) ? true : false;
                    profile.frontimage = ImagePath.Front;
                    profile.backimage = ImagePath.Back;
                    profile.leftimage = ImagePath.Left;
                    profile.rightimage = ImagePath.Right;
                    profile.otherimage = ImagePath.Other;
                }
                profile.iscompleted = ProductCompleteStatus(profile);
                _uow.ProductRP.Add(profile);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<Product> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully Listed Product Information." };
                }
                return new GenericResponse<Product> { ReturnedObject = null, IsSuccess = false, Message = "Failed Listing Product Information." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<Product> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<Product>> Update(int id, Product obj)
        {

            try
            {
                _uow.ProductRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<Product> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<Product> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<Product> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        private async Task<ImagePathModel> StoreImageTODirectory(ImageUploadModel upload, string registrationid, string gtin)
        {
            ImagePathModel path = new ImagePathModel();
            List<string> uploadedDirectories = new List<string>();
            path.Front = upload.FrontImage != null ? await FileUploadHandler(upload.FrontImage, $"brand_{registrationid}", $"{gtin}_frontimg") : null;
            path.Back = upload.BackImage != null ? await FileUploadHandler(upload.BackImage, $"brand_{registrationid}", $"{gtin}_backimg") : null;
            path.Left = upload.LeftImage != null ? await FileUploadHandler(upload.LeftImage, $"brand_{registrationid}", $"{gtin}_leftimg") : null;
            path.Right = upload.RightImage != null ? await FileUploadHandler(upload.RightImage, $"brand_{registrationid}", $"{gtin}_rightimg") : null;
            path.Other = upload.OtherImage != null ? await FileUploadHandler(upload.OtherImage, $"brand_{registrationid}", $"{gtin}_otherimg") : null;

            return path;
        }

        private string GenerateProductCode(GCPInformation gcpInfoObj, IEnumerable<GTINInformation> gtinInfoList, string regid)
        {
            string code = string.Empty;
            if (!string.IsNullOrEmpty(gcpInfoObj.CompanyPrefix))
            {
                string companyPrefix = gcpInfoObj.CompanyPrefix;
                string productCode = gtinInfoList.Max(x => x.productcode);
                int len = companyPrefix.Length;
                if (productCode == null)
                {
                    if (len == 11)
                        code = companyPrefix + "0";
                    else if (len == 10)
                        code = companyPrefix + "00";
                    else if (len == 9)
                        code = companyPrefix + "000";
                    else if (len == 8)
                        code = companyPrefix + "0000";
                    else if (len == 7)
                        code = companyPrefix + "00000";
                    else if (len == 6)
                        code = companyPrefix + "000000";
                }
                else
                {
                    var noOfGtins = gcpInfoObj.GtinCount;
                    for (int i = 0; i < noOfGtins; i++)
                    {
                        if (len == 11)
                            code = companyPrefix + "0";
                        else if (len == 10)
                            code = companyPrefix + "00";
                        else if (len == 9)
                            code = companyPrefix + "000";
                        else if (len == 8)
                            code = companyPrefix + "0000";
                        else if (len == 7)
                            code = companyPrefix + "00000";
                        else if (len == 6)
                            code = companyPrefix + "000000";

                        code = (Int64.Parse(code.ToString()) + i).ToString();
                        if (!gtinInfoList.Any(x => x.productcode == code)) break;
                    }
                }
            }
            return code;
        }

        private string CalculateChecksum(string productCode)
        {
            int sum = 0;
            productCode = productCode.Trim();
            for (int i = 0; i < 12; i++)
            {
                int v;
                if (!int.TryParse(productCode[i].ToString(), out v))
                    throw new ArgumentException("Invalid character encountered in specified code.");
                sum += (i % 2 == 0 ? v : v * 3);
            }
            int check = 10 - (sum % 10);
            var checksum = check % 10;
            return checksum.ToString();
        }



        private async Task<string> FileUploadHandler(IFormFile file, string gtinGenerated, string reference)
        {
            try
            {
                string concatData = reference + "_" + DateTime.Now.ToShortDateString() + "_" + DateTime.Now.TimeOfDay;

                Directory.CreateDirectory("Resources/Images/ProductImages/" + gtinGenerated);
                var folderName = Path.Combine("Resources", "Images", "ProductImages", gtinGenerated);
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileData = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var mainName = Path.GetFileNameWithoutExtension(fileData);
                    var extension = Path.GetExtension(fileData);
                    //var fileWithoutExtension = Path.Combine(mainName, $"_{concatData}");
                    var fileWithoutExtension = $"{concatData}";
                    fileWithoutExtension = fileWithoutExtension.Replace("/", "-");
                    fileWithoutExtension = fileWithoutExtension.Replace(".", "-");
                    fileWithoutExtension = fileWithoutExtension.Replace(":", "-");
                    //var fileName = Path.Combine(fileWithoutExtension, extension);
                    var fileName = $"{fileWithoutExtension}{extension}";
                    var fullPath = Path.Combine(pathToSave, fileName);
                    //Verify if file exist
                    if (File.Exists(fullPath))
                    {
                        File.Delete(fullPath);
                    }
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    return dbPath;
                }
            }
            catch (Exception e)
            {

            }
            return null;
        }
        //private void FileDeleteHandler(string dbFilePath)
        //{
        //    var filePath = Path.Combine("Resources", "Images", dbFilePath);
        //    var filePathToDelete = Path.Combine(Directory.GetCurrentDirectory(), filePath);
        //    if (File.Exists(filePathToDelete))
        //    {
        //        File.Delete(filePathToDelete);
        //    }
        //}

        private bool ProductCompleteStatus(Product profile)
        {
            //Check if VBG related fields have been fille
            if (!string.IsNullOrEmpty(profile.gtin) && !string.IsNullOrEmpty(profile.registrationid) && !string.IsNullOrEmpty(profile.productdescription) && profile.hasimage
                && profile.netcontent_id > 0 && profile.netweight > 0 && profile.brandinformation_id > 0 && profile.brickcategory_id > 0 && profile.netweight > 0)
            {
                return true;
            }
            return false;
        }

        public Task<GenericResponse<Product>> Save(Product obj)
        {
            throw new NotImplementedException();
        }

        public async Task<GenericResponse<Product>> SaveUpdateWithImage(Product profile, ImageUploadModel uploads)
        {
            profile.modifieddate = DateTime.UtcNow;
            return await AddUpdate(profile, uploads);
        }

        private async Task<GenericResponse<Product>> AddUpdate(Product profile, ImageUploadModel imageFile)
        {
            try
            {
                if (imageFile != null)
                {
                    var ImagePath = await StoreImageTODirectory(imageFile, profile.registrationid, profile.gtin);
                    profile.hasimage = (ImagePath.Front != null || ImagePath.Back != null || ImagePath.Left != null || ImagePath.Right != null || ImagePath.Other != null) ? true : false;
                    if (ImagePath.Front != null) profile.frontimage = ImagePath.Front;
                    if (ImagePath.Back != null) profile.backimage = ImagePath.Back;
                    if (ImagePath.Left != null) profile.leftimage = ImagePath.Left;
                    if (ImagePath.Right != null) profile.rightimage = ImagePath.Right;
                    if (ImagePath.Other != null) profile.otherimage = ImagePath.Other;
                }
                profile.iscompleted = ProductCompleteStatus(profile);
                _uow.ProductRP.Update(profile);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<Product> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully Updated Product Information." };
                }
                return new GenericResponse<Product> { ReturnedObject = null, IsSuccess = false, Message = "Failed Listing Product Information." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<Product> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }


}
