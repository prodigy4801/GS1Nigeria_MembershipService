using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class ProductTargetMarketSvc : IProductTargetMarketSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { "TargetMarket", "Product" };

        public ProductTargetMarketSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<ProductTargetMarket>> GetAll()
        {
            try
            {
                var records = await _uow.ProductTargetMarketRP.GetBy(null, x => x.OrderByDescending(y => y.id), null, null, _includes);
                return new GenericResponseList<ProductTargetMarket> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ProductTargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<ProductTargetMarket>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.ProductTargetMarketRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<ProductTargetMarket> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ProductTargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ProductTargetMarket>> GetByID(int id)
        {
            try
            {
                var record = await _uow.ProductTargetMarketRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<ProductTargetMarket> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ProductTargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<ProductTargetMarket>> GetByRegistrationID(string regId)
        {
            try
            {
                var record = await _uow.ProductTargetMarketRP.GetBy(x => x.registrationid == regId, null, null, null, _includes); ;
                return new GenericResponseList<ProductTargetMarket> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ProductTargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<ProductTargetMarket>> GetByProductRegistrationID(int prodId, string regId)
        {
            try
            {
                var record = await _uow.ProductTargetMarketRP.GetBy(x => x.product_id == prodId && x.registrationid == regId, null, null, null, _includes); ;
                return new GenericResponseList<ProductTargetMarket> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ProductTargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<bool> IsExist(int prodId, string regId, int targetMarketID)
        {
            bool existStatus = false;
            try
            {
                existStatus = await _uow.ProductTargetMarketRP.AnyAsync(x => x.product_id == prodId && x.registrationid == regId && x.targetmarket_id == targetMarketID);
                return existStatus;
            }
            catch (Exception ex)
            {
                return existStatus;
            }
        }

        public async Task<GenericResponse<ProductTargetMarket>> Remove(ProductTargetMarket obj)
        {

            try
            {
                _uow.ProductTargetMarketRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ProductTargetMarket> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<ProductTargetMarket> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ProductTargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ProductTargetMarket>> Remove(int id)
        {

            try
            {
                var obj = _uow.ProductTargetMarketRP.GetById(id);
                _uow.ProductTargetMarketRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ProductTargetMarket> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<ProductTargetMarket> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ProductTargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ProductTargetMarket>> Save(ProductTargetMarket profile)
        {
            if (profile.id == 0)
            {
                profile.datecreated = DateTime.Now;
                return await Add(profile);
            }
            else
            {
                return await Update(profile);
            }
        }

        private async Task<GenericResponse<ProductTargetMarket>> Add(ProductTargetMarket profile)
        {
            try
            {
                if (!await _uow.ProductTargetMarketRP.AnyAsync(y => y.registrationid == profile.registrationid && y.product_id == profile.product_id && y.targetmarket_id == profile.targetmarket_id))
                {
                    _uow.ProductTargetMarketRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<ProductTargetMarket> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added Product Target market record." };
                    }
                    return new GenericResponse<ProductTargetMarket> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<ProductTargetMarket> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<ProductTargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        //public async Task<GenericResponse<ProductTargetMarket>> SaveUpdate(ProductTargetMarket profile)
        //{
        //        return await Update(profile);
        //}
        private async Task<GenericResponse<ProductTargetMarket>> Update(ProductTargetMarket obj)
        {

            try
            {
                _uow.ProductTargetMarketRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ProductTargetMarket> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<ProductTargetMarket> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ProductTargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
