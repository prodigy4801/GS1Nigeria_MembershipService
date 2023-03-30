using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class GCPInformationSvc : IGCPInformationSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public GCPInformationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<GCPInformation>> GetAll()
        {
            try
            {
                var records = await _uow.GCPInformationRP.GetBy(null, x => x.OrderByDescending(y => y.ID), null, null, _includes);
                return new GenericResponseList<GCPInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GCPInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<GCPInformation>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.GCPInformationRP.GetBy(null, x => x.OrderByDescending(y => y.ID), skip, take, _includes);
                return new GenericResponseList<GCPInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GCPInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GCPInformation>> GetByID(int id)
        {
            try
            {
                var record = await _uow.GCPInformationRP.GetByFirstOrDefault(x => x.ID == id, _includes);
                return new GenericResponse<GCPInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GCPInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<GCPInformation>> GetListByRegistrationID(string regId)
        {
            try
            {
                var record = await _uow.GCPInformationRP.GetBy(x => x.Active && x.RegistrationID == regId, x => x.OrderByDescending(y => y.ID), null, null, _includes); ;
                return new GenericResponseList<GCPInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GCPInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<GCPInformation>> GetActiveListByRegistrationID(string regId)
        {
            try
            {
                var record = await _uow.GCPInformationRP.GetBy(x => x.Active && x.RegistrationID == regId, x => x.OrderByDescending(y => y.ID), null, null, _includes); ;
                return new GenericResponseList<GCPInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GCPInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GCPInformation>> Remove(GCPInformation obj)
        {

            try
            {
                _uow.GCPInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GCPInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GCPInformation>> Remove(int id)
        {

            try
            {
                var obj = _uow.GCPInformationRP.GetById(id);
                _uow.GCPInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GCPInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GCPInformation>> Save(GCPInformation profile)
        {
            if (profile.ID == 0)
            {
                profile.CreatedOn = DateTime.Now;
                return await Add(profile);
            }
            else
            {
                profile.UpdatedOn = DateTime.Now;
                return await Update(profile.ID, profile);
            }
        }

        public async Task<GenericResponse<GCPInformation>> SaveGCPAdditionalRequest(string registrationid, int requestedGTINCount)
        {
            try
            {
                var gcpInformationList = await _uow.GCPInformationRP.GetBy(x => x.RegistrationID == registrationid, y => y.OrderByDescending(z => z.ID), null, null, _includes);
                if (gcpInformationList != null && gcpInformationList.Count() > 0)
                { 
                    if (gcpInformationList.Select(x => !x.Active).First()) return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = false, Message = "Previous Request has not been assigned. Contact Admin for more information." };

                    var companyPrefix = gcpInformationList.Select(x => x.CompanyPrefix).First();
                    var sumIssuedGtins = gcpInformationList.Where(x => x.CompanyPrefix == companyPrefix).Select(x => x.GtinCount).Sum();
                    var MaximumAssignedGTINs = gcpInformationList.Where(x => x.CompanyPrefix == companyPrefix).Select(x => x.MaxGtin).First();
                    var totalGtins = sumIssuedGtins + requestedGTINCount;
                    if (totalGtins > MaximumAssignedGTINs) return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = false, Message = "Additional GTINs requested has exceeded the GCP assigned for this Company. Assign another Prefix to this Company." };

                    GCPInformation model = new GCPInformation()
                    {
                        Active = false,
                        AssignBy = null,
                        CompanyPrefix = companyPrefix,
                        CreatedOn = DateTime.Now,
                        GtinCount = requestedGTINCount,
                        IsEmailSent = false,
                        MaxGtin = MaximumAssignedGTINs,
                        RegistrationID = registrationid,
                        ID = 0
                    };
                    _uow.GCPInformationRP.Add(model);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<GCPInformation> { ReturnedObject = model, IsSuccess = true, Message = "Additional GTINS successfully assigned" };
                    }
                    return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed assigning request to this Company." };
                }
                return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = false, Message = "This company has not been assigned any GCP. Refer to GS1 Admin." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GCPInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        private async Task<GenericResponse<GCPInformation>> Add(GCPInformation profile)
        {
            try
            {
                if (!await _uow.GCPInformationRP.AnyAsync(y => y.RegistrationID == profile.RegistrationID))
                {
                    profile.Active = false;
                    _uow.GCPInformationRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<GCPInformation> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<GCPInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<GCPInformation>> Update(int id, GCPInformation obj)
        {

            try
            {
                _uow.GCPInformationRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GCPInformation> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<GCPInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GCPInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
