using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class ProductSvc : IProductSvc
    {
        private readonly IUnitOfWork _uow;

        public ProductSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _uow.ProductRP.GetAllAsync();
        }

        public async Task<Product> GetByID(int id)
        {
            return await _uow.ProductRP.GetByIdAsync(id);
        }

        public async Task<GenericResponse<Product>> Remove(Product obj)
        {
            GenericResponse<Product> response = new GenericResponse<Product>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.ProductRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    response.IsSuccess = true;
                    response.Message = "Successfully deleted record";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<GenericResponse<Product>> Remove(int id)
        {
            GenericResponse<Product> response = new GenericResponse<Product>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.ProductRP.GetById(id);
                _uow.ProductRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    response.IsSuccess = true;
                    response.Message = "Successfully deleted record";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<GenericResponse<Product>> Save(Product profile)
        {

            if (profile.id == 0)
            {
                profile.createddate = DateTime.Now;

                return await Add(profile);
            }
            else
            {
                profile.modifieddate = DateTime.Now;
                return await Update(profile.id, profile);
            }
        }

        public async Task<GenericResponse<List<Product>>> SaveProductList(IEnumerable<Product> products)
        {
            List<Product> mainProductStore = new List<Product>();
            GenericResponse<List<Product>> response = new GenericResponse<List<Product>>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                foreach(Product product in products)
                {
                    if (await _uow.ProductRP.IsExists(product))
                    {
                        response.Message += product.brandname + " exist in storage and cannot be saved. ";
                    }
                    else
                    {
                        mainProductStore.Add(product);
                        response.Message += product.brandname + " successfully saved. ";
                    }
                }
                if(mainProductStore.Count > 0)
                {
                    _uow.ProductRP.AddRange(mainProductStore);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        response.IsSuccess = true;
                        response.Message = " Successful Saved Product(s) to Storage.";
                        response.Data = mainProductStore;
                    }
                    else
                    {
                        response.Message += " Problem saving product records to storage. Please refer to technical team.";
                        response.IsSuccess = false;
                    }
                }
                else
                {
                    response.IsSuccess = true;
                    response.Message = " No product was successfully saved.";
                }
            }
            catch(Exception ex)
            {
                response.Message = ex.Message;
                response.IsSuccess = false;
            }
            return response;
        }

        private async Task<GenericResponse<Product>> Add(Product profile)
        {
            GenericResponse<Product> response = new GenericResponse<Product>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.ProductRP.IsExists(profile))
                {
                    _uow.ProductRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        response.IsSuccess = true;
                        response.Message = "Successfully added record.";
                        response.Data = profile;
                    }
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "User Information exist.";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
        private async Task<GenericResponse<Product>> Update(int id, Product obj)
        {
            GenericResponse<Product> response = new GenericResponse<Product>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.ProductRP.GetById(id);
                objEx.allergeninfo = obj.allergeninfo != string.Empty || obj.allergeninfo != null ? obj.allergeninfo : objEx.allergeninfo;
                objEx.backimage = obj.backimage != string.Empty || obj.backimage != null ? obj.backimage : objEx.backimage;
                objEx.brandname = obj.brandname != string.Empty || obj.brandname != null ? obj.brandname : objEx.brandname;
                objEx.brickcategory_id = obj.brickcategory_id > 0 ? obj.brickcategory_id : objEx.brickcategory_id;
                objEx.consumerfirstavailabilitydate = obj.consumerfirstavailabilitydate;
                objEx.dateoflisting = obj.dateoflisting;
                objEx.directionofuse = obj.directionofuse != string.Empty || obj.directionofuse != null ? obj.directionofuse : objEx.directionofuse;
                objEx.frontimage = obj.frontimage != string.Empty || obj.frontimage != null ? obj.frontimage : objEx.frontimage;
                objEx.grossweight = obj.grossweight;
                objEx.gtin = obj.gtin != string.Empty || obj.gtin != null ? obj.gtin : objEx.gtin;
                objEx.ingredients = obj.ingredients != string.Empty || obj.ingredients != null ? obj.ingredients : objEx.ingredients;
                objEx.hasimage = obj.hasimage;
                objEx.iscompleted = obj.iscompleted;
                objEx.lifespan = obj.lifespan;
                objEx.lifespanunit = obj.lifespanunit != string.Empty || obj.lifespanunit != null ? obj.lifespanunit : objEx.lifespanunit;
                objEx.marketingmessage = obj.marketingmessage != string.Empty || obj.marketingmessage != null ? obj.marketingmessage : objEx.marketingmessage;
                objEx.nafdacnumber = obj.nafdacnumber != string.Empty || obj.nafdacnumber != null ? obj.nafdacnumber : objEx.nafdacnumber;
                objEx.netcontent_id = obj.netcontent_id;
                objEx.netweight = obj.netweight;
                objEx.packaginglevel_id = obj.packaginglevel_id;
                objEx.packagingtype_id = obj.packagingtype_id;
                objEx.productdescription = obj.productdescription != string.Empty || obj.productdescription != null ? obj.productdescription : objEx.productdescription;
                objEx.storageinstruction = obj.storageinstruction != string.Empty || obj.storageinstruction != null ? obj.storageinstruction : objEx.storageinstruction;
                objEx.targetmarket_id = obj.targetmarket_id;

                //objEx.ID = Id;
                _uow.ProductRP.Update(objEx);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    response.IsSuccess = true;
                    response.Message = "Successfully updated record";
                    response.Data = objEx;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
