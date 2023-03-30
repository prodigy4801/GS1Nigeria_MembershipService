using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class TargetMarketSvc : ITargetMarketSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public TargetMarketSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<TargetMarket>> GetAll()
        {
            try
            {
                var records = await _uow.TargetMarketRP.GetAll();
                return new GenericResponseList<TargetMarket> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<TargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<TargetMarket>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.TargetMarketRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<TargetMarket> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<TargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<TargetMarket>> GetByMarketName(string marketname)
        {
            try
            {
                var record = await _uow.TargetMarketRP.GetByFirstOrDefault(x => x.name == marketname, _includes);
                return new GenericResponse<TargetMarket> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<TargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<TargetMarket>> GetByID(int id)
        {
            try
            {
                var record = await _uow.TargetMarketRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<TargetMarket> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<TargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<TargetMarket>> Remove(TargetMarket obj)
        {

            try
            {
                _uow.TargetMarketRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<TargetMarket> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<TargetMarket> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<TargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<TargetMarket>> Remove(int id)
        {

            try
            {
                var obj = _uow.TargetMarketRP.GetById(id);
                _uow.TargetMarketRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<TargetMarket> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<TargetMarket> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<TargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<TargetMarket>> Save(TargetMarket profile)
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

        private async Task<GenericResponse<TargetMarket>> Add(TargetMarket profile)
        {
            try
            {
                if (!await _uow.TargetMarketRP.AnyAsync(y => y.name == profile.name))
                {
                    _uow.TargetMarketRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<TargetMarket> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<TargetMarket> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<TargetMarket> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<TargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<TargetMarket>> Update(int id, TargetMarket obj)
        {

            try
            {
                _uow.TargetMarketRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<TargetMarket> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<TargetMarket> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<TargetMarket> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
