using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;
using MembershipPortal.data.ExternalEntries.Models;
using MembershipPortal.service.Helpers;
using MembershipPortal.service.Models;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.service.Concrete
{
    public class GTINRequestSvc : IGTINRequestSvc
    {
        private readonly IUnitOfWork _uow;
        private readonly ApplicationDBContext _context;
        private string[] _includes = { };

        public GTINRequestSvc(IUnitOfWork uow, ApplicationDBContext context)
        {
            _uow = uow;
            _context = context;
        }

        public async Task<GenericResponseList<GTINRequest>> GetAll(int skip, int take)
        {
            try
            {
                var records = await _uow.GTINRequestRP.GetBy(null, y => y.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<GTINRequest> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GTINRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<GTINRequest>> GetAll()
        {
            try
            {
                var records = await _uow.GTINRequestRP.GetBy(null, y => y.OrderByDescending(y => y.id), null, null, _includes);
                return new GenericResponseList<GTINRequest> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GTINRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINRequest>> GetByID(int id)
        {
            try
            {
                var record = await _uow.GTINRequestRP.GetBySingleOrDefault(x => x.id == id, _includes);
                return new GenericResponse<GTINRequest> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<GTINRequest>> GetListByRegistrationID(string regid)
        {
            try
            {
                var record = await _uow.GTINRequestRP.GetBy(x => x.registrationid == regid, y => y.OrderByDescending(x => x.id), null, null, _includes);
                return new GenericResponseList<GTINRequest> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GTINRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<bool>> IsExist(string registrationid)
        {
            try
            {
                var record = await _uow.GTINRequestRP.AnyAsync(x => x.registrationid == registrationid);
                return new GenericResponse<bool> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<bool> { ReturnedObject = false, IsSuccess = false, Message = ex.Message };
            }
        }

        public async Task<GenericResponse<GTINRequest>> Remove(GTINRequest obj)
        {
            try
            {
                _uow.GTINRequestRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GTINRequest> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<GTINRequest> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINRequest>> Remove(int id)
        {
            try
            {
                var obj = _uow.GTINRequestRP.GetById(id);
                _uow.GTINRequestRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GTINRequest> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<GTINRequest> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINRequest>> Save(GTINRequest profile, int? imageCount)
        {
            return await Add(profile, imageCount);
        }

        public Task<GenericResponse<GTINRequest>> Save(GTINRequest obj)
        {
            throw new NotImplementedException();
        }

        private async Task<GenericResponse<GTINRequest>> Add(GTINRequest profile, int? imageCount)
        {
            try
            {
                //1. Get CompanyID by RegistrationID
                var getCompanyObj = await _uow.CompanyRP.GetSingleByAsync(x => x.registrationid == profile.registrationid);
                if (getCompanyObj == null) return new GenericResponse<GTINRequest> { IsSuccess = false, Message = "Failed retrieving Company Information", ReturnedObject = null };
                profile.company_id = getCompanyObj.id;

                //2. Verify if its Additional or New Request using RegistrationID
                var gtinRequestListObj = await _uow.GTINRequestRP.GetBy(x => x.registrationid == profile.registrationid, null, null, null, _includes);
                if (gtinRequestListObj.Count() > 0 && gtinRequestListObj.Where(x => !x.isapproved) == null) return new GenericResponse<GTINRequest> { IsSuccess = false, ReturnedObject = null, Message = "You have a Barcode request that is still pending. Refer to GS1 Admin for more information." };
                if (gtinRequestListObj.Count() > 0 && gtinRequestListObj.Where(x => !x.isgcpassigned) == null) return new GenericResponse<GTINRequest> { IsSuccess = false, ReturnedObject = null, Message = "You have a Barcode request that has not been assigned. Refer to GS1 Admin for more information." };
                profile.requesttype = gtinRequestListObj.Any() ? "additional" : "initial";

                //3. Get GtinFee by GtinFeeID
                var getGtinFeeObj = await _uow.GTINFeeRP.GetBySingleOrDefault(x => x.ID == profile.gtinfee_id);
                if (getGtinFeeObj == null) return new GenericResponse<GTINRequest> { IsSuccess = false, Message = "Failed retrieving GTIN Fee", ReturnedObject = null };
                var gtinCount = StringManipulation.StripZeroFirst(getGtinFeeObj.Description.Split("-").Last());
                profile.gtincount = gtinCount;

                using (var transaction = await _context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        //4. Save Image request if added
                        ImageRequest imageReqModel = null;
                        if (imageCount != null && imageCount != 0)
                        {
                            imageReqModel = new ImageRequest()
                            {
                                id = 0,
                                imagecount = Convert.ToInt32(imageCount),
                                createdon = DateTime.Now,
                                imagetype = "GTIN",
                                approvedby = string.Empty,
                                isapproved = false,
                                registrationid = profile.registrationid,
                                requestedate = DateTime.Now,
                            };
                            await _context.ImageRequests.AddAsync(imageReqModel);
                            await _context.SaveChangesAsync();
                        }

                        //6. Save to GTINRequest
                        profile.dateofrequest = DateTime.Now;
                        profile.createdon = DateTime.Now;
                        profile.approvedby = string.Empty;
                        profile.imagerequest_id = imageReqModel == null ? null : imageReqModel.id;
                        profile.approvaldate = null;
                        profile.assigneddate = null;
                        profile.updatedon = null;
                        await _context.GTINRequests.AddAsync(profile);
                        await _context.SaveChangesAsync();

                        await transaction.CommitAsync();
                        return new GenericResponse<GTINRequest> { Message = "Successfully Requested for GTIN.", ReturnedObject = profile, IsSuccess = true };
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        return new GenericResponse<GTINRequest> { Message = ex.Message, ReturnedObject = profile, IsSuccess = false };
                    }
                }
            }
            catch(Exception ex)
            {
                return new GenericResponse<GTINRequest> { Message = ex.Message, ReturnedObject = profile, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<GTINRequest>> Update(int id, GTINRequest obj)
        {
            try
            {
                _uow.GTINRequestRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GTINRequest> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<GTINRequest> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINRequest> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
