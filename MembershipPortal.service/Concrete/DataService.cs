using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.core.ExternalDataRepository.RegistrationBackendRepository;
using MembershipPortal.service.MasterDataDTO;
using MembershipPortal.viewmodels;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.service.Concrete
{
    public class DataService : IDataService
    {
        private readonly ApplicationDBContext _context;
        private readonly RegistrationDBContext _rcontext;

        public DataService(ApplicationDBContext context, RegistrationDBContext rcontext)
        {
            _context = context;
            _rcontext = rcontext;
        }
        public async Task<ReturnSignature<List<ProductDTO>>> GetProductByEmail(ProductByEmailPayload payload)
        {
            try
            {
                List<ProductDTO> productsDTO = new List<ProductDTO>();
                ReturnSignature<List<ProductDTO>> signature = new ReturnSignature<List<ProductDTO>>() { Status = 0 };

                var company = _rcontext.Companies.Where(c => c.email == payload.Email).SingleOrDefault();
                if (company is null)
                {
                    signature.BadData.Add(payload.Email);
                    signature.Message.Add("Company information for this Email is not available");
                    signature.Status = 0;

                    return signature;

                }
                var registrationid = company.registrationid;
                var gtins = _context.Products.Where(p => p.registrationid == registrationid).Select(p => p.gtin).ToList();
                foreach (var gtin in gtins)
                {
                    try
                    {
                        ProductByGtinPayload gPayload = new ProductByGtinPayload { Gtin = gtin };
                        ReturnSignature<ProductDTO> productDTO = await GetProductByGtin(gPayload);
                        if (productDTO.Status == 1)
                        {
                            productsDTO.Add(productDTO.ReturnedObject);

                        }
                        else
                        {
                            signature.Message.Add(productDTO.Message.First());
                        }
                    }
                    catch (System.Exception)
                    {

                        signature.Message.Add("Something went wrong on " + gtin);
                    }
                }
                signature.ReturnedObject = productsDTO;

                if (signature.ReturnedObject != null)
                {
                    signature.Status = 1;
                    return signature;
                }
                return signature;
            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex.Message);
                return new ReturnSignature<List<ProductDTO>> { Status = 0 };
            }
        }

        public async Task<ReturnSignature<ProductDTO>> GetProductByGtin(ProductByGtinPayload payload)
        {
            try
            {
                var prod = await _context.Products.Where(p => p.gtin == payload.Gtin).SingleOrDefaultAsync();
                if (prod is null)
                {
                    return new ReturnSignature<ProductDTO>() { Status = 0, Message = new List<string>() { "Product information for this GTIN is not available" }, BadData = new List<string> { payload.Gtin } };
                }
                if (MandatoryAttributesFulfield(prod, payload.MandatoryAttributes))
                {


                    ProductDTO dto = new ProductDTO
                    {
                        allergeninfo = prod.allergeninfo,
                        backimage = prod.backimage,
                        brandname = prod.brandname,
                        brickcategory_id = prod.brickcategory_id,
                        consumerfirstavailabilitydate = prod.consumerfirstavailabilitydate,
                        directionofuse = prod.directionofuse,
                        frontimage = prod.frontimage,
                        grossweight = prod.grossweight,
                        gtin = prod.gtin,
                        ingredients = prod.ingredients,
                        //lifespan = prod.lifespan,
                        lifespanunit = prod.lifespanunit,
                        marketingmessage = prod.marketingmessage,
                        nafdacnumber = prod.nafdacnumber,
                        netcontent_id = prod.netcontent_id,
                        netweight = prod.netweight,
                        storageinstruction = prod.storageinstruction,
                        productdescription = prod.productdescription,
                        packaginglevel_id = prod.packaginglevel_id,
                        packagingtype_id = prod.packagingtype_id,
                        targetmarket_id = prod.targetmarket_id

                    };
                    return new ReturnSignature<ProductDTO>
                    {
                        Message = new List<string>() { "Success" },
                        ReturnedObject = dto,
                        Status = 1
                    };
                }
                else
                {
                    return new ReturnSignature<ProductDTO>() { Status = 0, Message = new List<string>() { "This GTIN did not meet mandatory attribute requirement " + payload.Gtin }, BadData = new List<string> { payload.Gtin } };
                }
            }
            catch (System.Exception ex)
            {

                return new ReturnSignature<ProductDTO>() { Status = 0, Message = new List<string>() { "Something is wrong, Please contact GS1 Nigeria " + payload.Gtin }, BadData = new List<string> { payload.Gtin } };
            }

        }

        private bool MandatoryAttributesFulfield(data.Product prod, List<string> mandatoryAttributes)
        {
            bool fulfiled = true;
            foreach (var attr in mandatoryAttributes)
            {
                switch (attr)
                {
                    case "allergeninfo":
                        fulfiled = prod.allergeninfo == null || prod.allergeninfo == "" ? false : true;
                        break;
                    case "backimage":
                        fulfiled = prod.backimage == null || prod.backimage == "" ? false : true;
                        break;
                    case "brandname":
                        fulfiled = prod.brandname == null || prod.brandname == "" ? false : true;
                        break;
                    case "brickcategory_id":
                        fulfiled = prod.brickcategory_id == null ? false : true;
                        break;
                    case "consumerfirstavailabilitydate":
                        fulfiled = prod.consumerfirstavailabilitydate == null ? false : true;
                        break;
                    case "directionofuse":
                        fulfiled = prod.directionofuse == null || prod.directionofuse == "" ? false : true;
                        break;
                    case "frontimage":
                        fulfiled = prod.frontimage == null || prod.frontimage == "" ? false : true;
                        break;
                    case "grossweight":
                        fulfiled = prod.grossweight == 0.0 ? false : true;
                        break;
                    case "gtin":
                        fulfiled = prod.gtin == null || prod.gtin == "" ? false : true;
                        break;
                    case "ingredients":
                        fulfiled = prod.ingredients == null || prod.ingredients == "" ? false : true;
                        break;

                    case "lifespan":
                        fulfiled = prod.lifespan == null || prod.lifespan == 0 ? false : true;
                        break;
                    case "lifespanunit":
                        fulfiled = prod.lifespanunit == null || prod.lifespanunit == "" ? false : true;
                        break;
                    case "marketingmessage":
                        fulfiled = prod.marketingmessage == null || prod.marketingmessage == "" ? false : true;
                        break;
                    case "nafdacnumber":
                        fulfiled = prod.nafdacnumber == null || prod.nafdacnumber == "" ? false : true;
                        break;
                    case "netcontent_id":
                        fulfiled = prod.netcontent_id == null ? false : true;
                        break;
                    case "netweight":
                        fulfiled = prod.netweight == 0.0 || prod.netweight == null ? false : true;
                        break;
                    case "storageinstruction":
                        fulfiled = prod.storageinstruction == null || prod.storageinstruction == "" ? false : true;
                        break;
                    case "productdescription":
                        fulfiled = prod.productdescription == null || prod.productdescription == "" ? false : true;
                        break;
                    case "packaginglevel_id":
                        fulfiled = prod.packaginglevel_id == null ? false : true;
                        break;
                    case "packagingtype_id":
                        fulfiled = prod.packagingtype_id == null ? false : true;
                        break;
                    case "targetmarket_id":
                        fulfiled = prod.targetmarket_id == null ? false : true;
                        break;

                    default:
                        return fulfiled;
                }
            }
            return fulfiled;
        }

        public async Task<ReturnSignature<CompanyProductDTO>> OnboardCompanyByEmail(OnboardByEmailPayload payload)
        {
            ReturnSignature<List<ProductDTO>> products = new ReturnSignature<List<ProductDTO>>();
            ReturnSignature<CompanyProductDTO> signature = new ReturnSignature<CompanyProductDTO>() { Status = 0 };
            try
            {


                var company = _rcontext.Companies.Where(c => c.email == payload.Email).SingleOrDefault();
                if (company is null)
                {
                    signature.BadData.Add(payload.Email);
                    signature.Message.Add("Company information for this Email is not available");
                    signature.Status = 0;

                    return signature;

                }
                var companyDTO = new CompanyDTO()
                {
                    companyaddress = company.companyaddress,
                    companyname = company.companyname,
                    facebookaccount = company.facebookaccount,
                    factoryaddress = company.factoryaddress,
                    instagramaccount = company.instagramaccount,
                    twitteraccount = company.twitteraccount,
                    phonenumber = company.phonenumber,
                    email = company.email,
                    websiteaddress = company.websiteaddress,
                    country_id = company.country_id
                };
                ProductByEmailPayload gPayload = new ProductByEmailPayload() { Email = payload.Email, MandatoryAttributes = payload.MandatoryAttributes };

                products = await GetProductByEmail(gPayload);
                CompanyProductDTO companyprod = new CompanyProductDTO() { Company = companyDTO, Products = products.ReturnedObject };
                signature.Status = products.Status;
                signature.BadData = products.BadData;
                signature.Message = products.Message;
                signature.ReturnedObject = companyprod;
                if (companyDTO is not null)
                {
                    signature.Status = 1;
                }
                return signature;


            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                signature.BadData.Add(payload.Email);
                signature.Message.Add("Company information for this Email is not available");
                signature.Status = 0;

                return signature;
            }
        }

        public async Task<ReturnSignature<PackedDTOForEPCIS>> GetDataForPrep(List<string> gtins)
        {
            try
            {
                var gtindetails = new List<GtinPrefixDTO>();
                var email = "";
                var gtininfo = await _context.GTINInformations.Where(g => gtins.Contains(g.gtin)).Select(s => new { regid = s.registrationid, gtin = s.gtin, prefix = s.companyprefix }).ToListAsync();
                var company = await _rcontext.Companies.Where(c => c.registrationid == gtininfo.First().regid).FirstOrDefaultAsync();
                if (company is not null)
                {
                    email = company.email;
                }

                foreach (var item in gtininfo)
                {
                    var gd = new GtinPrefixDTO
                    {
                        CompanyEmail = email,
                        Gtin = item.gtin,
                        Prefix = item.prefix
                    };
                    gtindetails.Add(gd);
                }
                var prefixes = _context.GCPInformations.Where(g => g.RegistrationID == gtininfo.First().regid).Select(s => s.CompanyPrefix).ToList();
                var packed = new PackedDTOForEPCIS
                {
                    AllPrefixes = prefixes,
                    GtinPrefixDTO = gtindetails

                };

                return new ReturnSignature<PackedDTOForEPCIS> { Status = 1, ReturnedObject = packed };
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new ReturnSignature<PackedDTOForEPCIS> { Status = 0, Message=new List<string>{ex.Message,ex.InnerException.Message}};
            }
        }

        public async Task<ReturnSignature<List<LocationInformation>>> GetLocationInformation(string email)
        {
            var locations = new List<LocationInformation>();
            var companyObj = await _rcontext.Companies.Where(c => c.email == email).SingleOrDefaultAsync();
            if (companyObj is null)
            {
                return new ReturnSignature<List<LocationInformation>>
                {
                    Status = 0,
                    Message = new List<string> { "Company Not Exist" },
                    BadData = new List<string> { email }
                };
            }

            var gInfo = await _context.GLNInformations.Where(g => g.registrationid == companyObj.registrationid).ToListAsync();
            foreach (var g in gInfo)
            {
                var gRequest = await _rcontext.GLNRequests.Where(r => r.id == g.glnrequestid).SingleOrDefaultAsync();
                if (gRequest is null)
                {
                    return new ReturnSignature<List<LocationInformation>>
                    {
                        Status = 0,
                        Message = new List<string> { "GLN Error" },
                        BadData = new List<string> { email }
                    };
                }

                locations.Add(new LocationInformation
                {
                    Address = gRequest.address,
                    Gln = g.gln,
                    Latitude = gRequest.latitude.ToString(),
                    Longitude = gRequest.longitude.ToString()

                });
            }
            return new ReturnSignature<List<LocationInformation>> { Status = 1, ReturnedObject = locations };

        }
    }
}