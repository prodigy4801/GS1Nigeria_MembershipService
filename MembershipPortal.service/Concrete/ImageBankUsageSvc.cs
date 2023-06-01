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
    public class ImageBankUsageSvc : IImageBankUsageSvc
    {
        private readonly ApplicationDBContext _context;
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public ImageBankUsageSvc(IUnitOfWork uow, ApplicationDBContext context)
        {
            _uow = uow;
            _context = context;
        }

        public async Task<GenericResponseList<ImageBankUsage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<GenericResponse<ImageBankUsage>> GetByID(int id)
        {
            try
            {
                var record = await _uow.ImageBankUsageRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<ImageBankUsage> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageBankUsage> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<ImageBankUsage>> GetByRegistrationID(string registrationid)
        {
            try
            {
                var record = await _uow.ImageBankUsageRP.GetBy(x => x.registrationid == registrationid, null, null, null, _includes);
                return new GenericResponseList<ImageBankUsage> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ImageBankUsage> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ImageBankUsage>> GetByGTIN(string gtin)
        {
            try
            {
                var record = await _uow.ImageBankUsageRP.GetByFirstOrDefault(x => x.gtin == gtin, _includes);
                return new GenericResponse<ImageBankUsage> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageBankUsage> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ImageBankUsage>> GetByRegID_Gtin(string gtin, string registrationid)
        {
            try
            {
                var record = await _uow.ImageBankUsageRP.GetByFirstOrDefault(x => x.registrationid == registrationid && x.gtin == gtin, _includes);
                return new GenericResponse<ImageBankUsage> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch(Exception ex)
            {
                return new GenericResponse<ImageBankUsage> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponse<ImageBankUsage>> Remove(ImageBankUsage obj)
        {
            throw new NotImplementedException();
        }

        public async Task<GenericResponse<ImageBankUsage>> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<GenericResponse<ImageBankUsage>> Save(ImageBankUsage profile)
        {
            try
            {
                if (!await _uow.ImageBankUsageRP.AnyAsync(y => y.gtin == profile.gtin))
                {
                    profile.CreatedOn = DateTime.UtcNow;
                    profile.downloadCount = 1;

                    _uow.ImageBankUsageRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<ImageBankUsage> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully generated barcode." };
                    }
                    return new GenericResponse<ImageBankUsage> { ReturnedObject = null, IsSuccess = false, Message = "Failed to generate barcode." };
                }
                else
                {
                    //get image bank usage by gtin
                    var getRecord = await _uow.ImageBankUsageRP.GetBySingleOrDefault(x => x.gtin == profile.gtin);
                    if(getRecord != null)
                    {
                        getRecord.downloadCount += 1;
                        getRecord.ModifiedOn = DateTime.UtcNow;

                        _uow.ImageBankUsageRP.Update(getRecord);
                        int result = await _uow.Complete();
                        if (result > 0)
                        {
                            return new GenericResponse<ImageBankUsage> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully regenerated barcode." };
                        }
                        return new GenericResponse<ImageBankUsage> { ReturnedObject = null, IsSuccess = false, Message = "Failed to regenerate barcode." };
                    }
                    return new GenericResponse<ImageBankUsage> { ReturnedObject = null, IsSuccess = false, Message = "Failed to retrieve generated barcode from storage. Contact GS1 Nigeria Technical Team." };
                }
            }
            catch(Exception ex)
            {
                return new GenericResponse<ImageBankUsage> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
