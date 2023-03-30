using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class ITFInformationSvc : IITFInformationSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public ITFInformationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<ITFInformation>> GetAll()
        {
            try
            {
                var records = await _uow.ITFInformationRP.GetBy(null, x => x.OrderByDescending(y => y.id), null, null, _includes);
                return new GenericResponseList<ITFInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ITFInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<ITFInformation>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.ITFInformationRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<ITFInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ITFInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ITFInformation>> GetByID(int id)
        {
            try
            {
                var record = await _uow.ITFInformationRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<ITFInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ITFInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ITFInformation>> GetByRegistrationID(string regId)
        {
            try
            {
                var record = await _uow.ITFInformationRP.GetByFirstOrDefault(x => x.registrationid == regId, _includes); ;
                return new GenericResponse<ITFInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ITFInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ITFInformation>> Remove(ITFInformation obj)
        {

            try
            {
                _uow.ITFInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ITFInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<ITFInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ITFInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ITFInformation>> Remove(int id)
        {

            try
            {
                var obj = _uow.ITFInformationRP.GetById(id);
                _uow.ITFInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ITFInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<ITFInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ITFInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ITFInformation>> Save(ITFInformation profile)
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

        private async Task<GenericResponse<ITFInformation>> Add(ITFInformation profile)
        {
            try
            {
                if (!await _uow.ITFInformationRP.AnyAsync(y => y.registrationid == profile.registrationid))
                {
                    _uow.ITFInformationRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<ITFInformation> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<ITFInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<ITFInformation> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<ITFInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<ITFInformation>> Update(int id, ITFInformation obj)
        {

            try
            {
                _uow.ITFInformationRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ITFInformation> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<ITFInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ITFInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
