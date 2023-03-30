using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class ExternalUnifiedModelSvc : IExternalUnifiedModelSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public ExternalUnifiedModelSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<ExternalUnifiedModel>> GetAll()
        {
            try
            {
                var records = await _uow.ExternalUnifiedModelRP.GetBy(null, x => x.OrderByDescending(y => y.id), null, null, _includes);
                return new GenericResponseList<ExternalUnifiedModel> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ExternalUnifiedModel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<ExternalUnifiedModel>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.ExternalUnifiedModelRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<ExternalUnifiedModel> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ExternalUnifiedModel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ExternalUnifiedModel>> GetByID(int id)
        {
            try
            {
                var record = await _uow.ExternalUnifiedModelRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ExternalUnifiedModel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ExternalUnifiedModel>> GetByProductID(int productId)
        {
            try
            {
                var record = await _uow.ExternalUnifiedModelRP.GetByFirstOrDefault(x => x.product_id == productId, _includes); ;
                return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ExternalUnifiedModel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<bool>> IsExist(ExternalUnifiedModel profile)
        {
            try
            {
                var record = await _uow.ExternalUnifiedModelRP.AnyAsync(x => x.product_id == profile.product_id);
                return new GenericResponse<bool> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<bool> { ReturnedObject = false, IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<GenericResponse<ExternalUnifiedModel>> Remove(ExternalUnifiedModel obj)
        {

            try
            {
                _uow.ExternalUnifiedModelRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ExternalUnifiedModel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ExternalUnifiedModel>> Remove(int id)
        {

            try
            {
                var obj = _uow.ExternalUnifiedModelRP.GetById(id);
                _uow.ExternalUnifiedModelRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ExternalUnifiedModel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ExternalUnifiedModel>> Save(ExternalUnifiedModel profile)
        {
            if (profile.id == 0)
            {
                profile.datecreated = DateTime.Now;
                return await Add(profile);
            }
            else
            {
                profile.datemodified = DateTime.Now;
                return await Update(profile.id, profile);
            }
        }

        private async Task<GenericResponse<ExternalUnifiedModel>> Add(ExternalUnifiedModel profile)
        {
            try
            {
                if (!await _uow.ExternalUnifiedModelRP.AnyAsync(y => y.product_id == profile.product_id && y.productform == profile.productform))
                {
                    _uow.ExternalUnifiedModelRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<ExternalUnifiedModel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<ExternalUnifiedModel>> Update(int id, ExternalUnifiedModel obj)
        {

            try
            {
                _uow.ExternalUnifiedModelRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<ExternalUnifiedModel> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ExternalUnifiedModel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
