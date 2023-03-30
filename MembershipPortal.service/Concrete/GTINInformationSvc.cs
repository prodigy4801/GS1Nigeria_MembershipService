using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class GTINInformationSvc : IGTINInformationSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public GTINInformationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<GTINInformation>> GetAll()
        {
            try
            {
                var records = await _uow.GTINInformationRP.GetBy(null, x => x.OrderByDescending(y => y.id), null, null, _includes);
                return new GenericResponseList<GTINInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GTINInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<GTINInformation>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.GTINInformationRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<GTINInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GTINInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINInformation>> GetByID(int id)
        {
            try
            {
                var record = await _uow.GTINInformationRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<GTINInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINInformation>> GetByRegistrationID(string regId)
        {
            try
            {
                var record = await _uow.GTINInformationRP.GetByFirstOrDefault(x => x.registrationid == regId, _includes); ;
                return new GenericResponse<GTINInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<GTINInformation>> GetListByRegistrationID(string regId)
        {
            try
            {
                var record = await _uow.GTINInformationRP.GetBy(x => x.registrationid == regId, x => x.OrderByDescending(y => y.id), null, null, _includes); ;
                return new GenericResponseList<GTINInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GTINInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<long>> CountListedGtinByRegID(string regId)
        {
            try
            {
                var record = await _uow.GTINInformationRP.CountAsync(x => x.registrationid == regId); ;
                return new GenericResponse<long> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<long> { Message = ex.Message, ReturnedObject = 0, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINInformation>> Remove(GTINInformation obj)
        {

            try
            {
                _uow.GTINInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GTINInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<GTINInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINInformation>> Remove(int id)
        {

            try
            {
                var obj = _uow.GTINInformationRP.GetById(id);
                _uow.GTINInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GTINInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<GTINInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINInformation>> Save(GTINInformation profile)
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

        private async Task<GenericResponse<GTINInformation>> Add(GTINInformation profile)
        {
            try
            {
                if (!await _uow.GTINInformationRP.AnyAsync(y => y.registrationid == profile.registrationid))
                {
                    _uow.GTINInformationRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<GTINInformation> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<GTINInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<GTINInformation> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<GTINInformation>> Update(int id, GTINInformation obj)
        {

            try
            {
                _uow.GTINInformationRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GTINInformation> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<GTINInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
