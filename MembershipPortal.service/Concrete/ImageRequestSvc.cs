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

        public async Task<GenericResponse<ImageRequest>> SaveImage(string registrationid, int imageCount, string imageType)
        {
            try
            {
                //Validation of Request for imag
                var gtinRequestObj = await _uow.GTINRequestRP.GetBy(x => x.registrationid == registrationid, null, null, null, _includes);
                if(gtinRequestObj == null) return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "No GTIN available. Cannot process this request." };
                var gtinCount = gtinRequestObj.Select(x => x.gtincount).Sum();
                var imageRequestObj = await _uow.ImageRequestRP.GetBy(x => x.registrationid == registrationid, null, null, null, _includes);
                if (imageRequestObj.Select(x => !x.isapproved).Any()) return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "Pending Image request not approved exist in your repository. Contact GS1 Nigeria Admin for more information." };
                var totalImageRequestCount = imageRequestObj.Count() > 0 ? (imageCount + imageRequestObj.Select(x => x.imagecount).Sum()) : imageCount;
                if(totalImageRequestCount > gtinCount) return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "Total Images requested has exceeded the total number of GTINs available." };

                ImageRequest profile = new ImageRequest
                {
                    approvedby = null,
                    createdon = DateTime.UtcNow,
                    id = 0,
                    imagecount = imageCount,
                    imagetype = imageType,
                    isapproved = false,
                    registrationid = registrationid,
                    requestedate = DateTime.UtcNow,
                    updatedon = DateTime.UtcNow
                };
                _uow.ImageRequestRP.Add(profile);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ImageRequest> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully sent image request to GS1 Nigeria. Check back for activation." };
                }
                return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "Failed to initiate image request to GS1 Nigeria. Contact GS1 Nigeria Technical Team." };
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
                profile.createdon = DateTime.UtcNow;
                return await Add(profile);
            }
            else
            {
                profile.updatedon = DateTime.UtcNow;
                return await Update(profile.id, profile);
            }
        }

        private async Task<GenericResponse<ImageRequest>> Add(ImageRequest profile)
        {
            try
            {
                profile.requestedate = DateTime.UtcNow;
                profile.updatedon = DateTime.UtcNow;
                _uow.ImageRequestRP.Add(profile);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ImageRequest> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                }
                return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                //if (!await _uow.ImageRequestRP.AnyAsync(y => y.registrationid == profile.registrationid))
                //{

                //}
                //return new GenericResponse<ImageRequest> { ReturnedObject = null, IsSuccess = false, Message = "User Profile already exist in storage." };
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
