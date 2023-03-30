using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class BrandInformationSvc : IBrandInformationSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public BrandInformationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<BrandInformation>> GetAll()
        {
            try
            {
                var records = await _uow.BrandInformationRP.GetBy(null, x => x.OrderByDescending(y => y.id), null, null, _includes);
                return new GenericResponseList<BrandInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<BrandInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<BrandInformation>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.BrandInformationRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<BrandInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<BrandInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<BrandInformation>> GetAllActive(int? skip, int? take)
        {
            try
            {
                var records = await _uow.BrandInformationRP.GetBy(x => x.isActive, y => y.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<BrandInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<BrandInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<BrandInformation>> GetByID(int id)
        {
            try
            {
                var record = await _uow.BrandInformationRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<BrandInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<BrandInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<BrandInformation>> GetByBrandName(string brandname)
        {
            try
            {
                var record = await _uow.BrandInformationRP.GetByFirstOrDefault(x => x.brandname == brandname, _includes);
                return new GenericResponse<BrandInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<BrandInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<BrandInformation>> GetByRegistrationID(string regId)
        {
            try
            {
                var record = await _uow.BrandInformationRP.GetBy(x => x.registrationid == regId, y => y.OrderByDescending(a => a.id) , null, null, _includes); ;
                return new GenericResponseList<BrandInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<BrandInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<bool>> IsExist(BrandInformation profile)
        {
            try
            {
                var record = await _uow.BrandInformationRP.AnyAsync(x => x.brandname == profile.brandname);
                return new GenericResponse<bool> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<bool> { ReturnedObject = false, IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<GenericResponse<BrandInformation>> Remove(BrandInformation obj)
        {

            try
            {
                _uow.BrandInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<BrandInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<BrandInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<BrandInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<BrandInformation>> Remove(int id)
        {

            try
            {
                var obj = _uow.BrandInformationRP.GetById(id);
                _uow.BrandInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<BrandInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<BrandInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<BrandInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<BrandInformation>> Save(BrandInformation profile)
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

        private async Task<GenericResponse<BrandInformation>> Add(BrandInformation profile)
        {
            try
            {
                if (!await _uow.BrandInformationRP.AnyAsync(y => y.brandname == profile.brandname))
                {
                    _uow.BrandInformationRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<BrandInformation> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<BrandInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<BrandInformation> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<BrandInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<BrandInformation>> Update(int id, BrandInformation obj)
        {

            try
            {
                _uow.BrandInformationRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<BrandInformation> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<BrandInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<BrandInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
