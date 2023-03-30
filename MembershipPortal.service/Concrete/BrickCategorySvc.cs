using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class BrickCategorySvc : IBrickCategorySvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public BrickCategorySvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<BrickCategory>> GetAll()
        {
            try
            {
                var records = await _uow.BrickCategoryRP.GetAll();
                return new GenericResponseList<BrickCategory> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<BrickCategory> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<BrickCategory>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.BrickCategoryRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<BrickCategory> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<BrickCategory> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<BrickCategory>> GetByID(int id)
        {
            try
            {
                var record = await _uow.BrickCategoryRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<BrickCategory> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<BrickCategory> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<BrickCategory>> GetByBrickName(string brickname)
        {
            try
            {
                var record = await _uow.BrickCategoryRP.GetByFirstOrDefault(x => x.brick == brickname, _includes);
                return new GenericResponse<BrickCategory> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<BrickCategory> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<BrickCategory>> Remove(BrickCategory obj)
        {

            try
            {
                _uow.BrickCategoryRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<BrickCategory> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<BrickCategory> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<BrickCategory> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<BrickCategory>> Remove(int id)
        {

            try
            {
                var obj = _uow.BrickCategoryRP.GetById(id);
                _uow.BrickCategoryRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<BrickCategory> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<BrickCategory> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<BrickCategory> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<BrickCategory>> Save(BrickCategory profile)
        {
            if (profile.id == 0)
            {
                return await Add(profile);
            }
            else
            {
                return await Update(profile.id, profile);
            }
        }

        private async Task<GenericResponse<BrickCategory>> Add(BrickCategory profile)
        {
            try
            {
                _uow.BrickCategoryRP.Add(profile);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<BrickCategory> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                }
                return new GenericResponse<BrickCategory> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };

            }
            catch (Exception ex)
            {
                return new GenericResponse<BrickCategory> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<BrickCategory>> Update(int id, BrickCategory obj)
        {

            try
            {
                _uow.BrickCategoryRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<BrickCategory> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<BrickCategory> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<BrickCategory> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
