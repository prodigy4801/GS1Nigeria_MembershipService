using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class GLNInformationSvc : IGLNInformationSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public GLNInformationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<GLNInformation>> GetAll()
        {
            try
            {
                var records = await _uow.GLNInformationRP.GetBy(null, x => x.OrderByDescending(y => y.id), null, null, _includes);
                return new GenericResponseList<GLNInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GLNInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<GLNInformation>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.GLNInformationRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<GLNInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GLNInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GLNInformation>> GetByID(int id)
        {
            try
            {
                var record = await _uow.GLNInformationRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<GLNInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GLNInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<GLNInformation>> GetByRegistrationID(string regId)
        {
            try
            {
                var record = await _uow.GLNInformationRP.GetBy(x => x.registrationid == regId, null, null, null, _includes); ;
                return new GenericResponseList<GLNInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GLNInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GLNInformation>> Remove(GLNInformation obj)
        {

            try
            {
                _uow.GLNInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GLNInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<GLNInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GLNInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GLNInformation>> Remove(int id)
        {

            try
            {
                var obj = _uow.GLNInformationRP.GetById(id);
                _uow.GLNInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GLNInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<GLNInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GLNInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GLNInformation>> Save(GLNInformation profile)
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

        private async Task<GenericResponse<GLNInformation>> Add(GLNInformation profile)
        {
            try
            {
                if (!await _uow.GLNInformationRP.AnyAsync(y => y.registrationid == profile.registrationid))
                {
                    _uow.GLNInformationRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<GLNInformation> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<GLNInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<GLNInformation> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<GLNInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<GLNInformation>> Update(int id, GLNInformation obj)
        {

            try
            {
                _uow.GLNInformationRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GLNInformation> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<GLNInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GLNInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
