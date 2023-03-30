using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class ImageRequestSvc : IImageRequestSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public ImageRequestSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<ImageRequest>> GetAll()
        {
            try
            {
                var records = await _uow.ImageRequestRP.GetAll();
                return new GenericResponseList<ImageRequest> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ImageRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<ImageRequest>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.ImageRequestRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<ImageRequest> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ImageRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ImageRequest>> GetByID(int id)
        {
            try
            {
                var record = await _uow.ImageRequestRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<ImageRequest> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<ImageRequest>> GetListByRegistrationID(string registrationid)
        {
            try
            {
                var record = await _uow.ImageRequestRP.GetBy(x => x.registrationid == registrationid, y => y.OrderByDescending(x => x.id), null, null, _includes);
                return new GenericResponseList<ImageRequest> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ImageRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ImageRequest>> Remove(ImageRequest obj)
        {

            try
            {
                _uow.ImageRequestRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ImageRequest>> Remove(int id)
        {

            try
            {
                var obj = _uow.ImageRequestRP.GetById(id);
                _uow.ImageRequestRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ImageRequest>> Save(ImageRequest profile)
        {
            if (profile.id == 0)
            {
                profile.createdon = DateTime.Now;
                return await Add(profile);
            }
            else
            {
                profile.updatedon = DateTime.Now;
                return await Update(profile.id, profile);
            }
        }

        private async Task<GenericResponse<ImageRequest>> Add(ImageRequest profile)
        {
            try
            {
                if (!await _uow.ImageRequestRP.AnyAsync(y => y.registrationid == profile.registrationid))
                {
                    _uow.ImageRequestRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<ImageRequest> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "User Profile already exist in storage." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }

        }
        private async Task<GenericResponse<ImageRequest>> Update(int id, ImageRequest obj)
        {

            try
            {
                _uow.ImageRequestRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ImageRequest> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
