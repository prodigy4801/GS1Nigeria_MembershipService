using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class NetContentSvc : INetContentSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public NetContentSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<NetContent>> GetAll()
        {
            try
            {
                var records = await _uow.NetContentRP.GetAll();
                return new GenericResponseList<NetContent> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<NetContent> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<NetContent>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.NetContentRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<NetContent> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<NetContent> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<NetContent>> GetByID(int id)
        {
            try
            {
                var record = await _uow.NetContentRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<NetContent> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<NetContent> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<NetContent>> GetByContentName(string contentname)
        {
            try
            {
                var record = await _uow.NetContentRP.GetByFirstOrDefault(x => x.name == contentname, _includes);
                return new GenericResponse<NetContent> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<NetContent> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<NetContent>> Remove(NetContent obj)
        {

            try
            {
                _uow.NetContentRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<NetContent> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<NetContent> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<NetContent> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<NetContent>> Remove(int id)
        {

            try
            {
                var obj = _uow.NetContentRP.GetById(id);
                _uow.NetContentRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<NetContent> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<NetContent> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<NetContent> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<NetContent>> Save(NetContent profile)
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

        private async Task<GenericResponse<NetContent>> Add(NetContent profile)
        {
            try
            {
                if (!await _uow.NetContentRP.AnyAsync(y => y.name == profile.name))
                {
                    _uow.NetContentRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<NetContent> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<NetContent> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<NetContent> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<NetContent> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<NetContent>> Update(int id, NetContent obj)
        {

            try
            {
                _uow.NetContentRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<NetContent> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<NetContent> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<NetContent> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
