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

        public BrandInformationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<BrandInformation>> GetAll()
        {
            return await _uow.BrandInformationRP.GetAllAsync();
        }

        public async Task<IEnumerable<BrandInformation>> GetByRegistrationID(string regID)
        {
            return await _uow.BrandInformationRP.GetBy(s => s.registrationid == regID);
        }

        public async Task<BrandInformation> GetByID(int id)
        {
            return await _uow.BrandInformationRP.GetByIdAsync(id);
        }

        public async Task<GenericResponse<BrandInformation>> Remove(BrandInformation obj)
        {
            GenericResponse<BrandInformation> response = new GenericResponse<BrandInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.BrandInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    response.IsSuccess = true;
                    response.Message = "Successfully deleted record";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<bool> RecordExist(BrandInformation record)
        {
            bool response = false;

            try
            {
                if (await _uow.BrandInformationRP.IsExists(record))
                {
                    response = true;
                }
            }
            catch (Exception ex)
            {

            }

            return response;
        }

        public async Task<GenericResponse<BrandInformation>> Remove(int id)
        {
            GenericResponse<BrandInformation> response = new GenericResponse<BrandInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.BrandInformationRP.GetById(id);
                _uow.BrandInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    response.IsSuccess = true;
                    response.Message = "Successfully deleted record";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }

            return response;
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
            GenericResponse<BrandInformation> response = new GenericResponse<BrandInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.BrandInformationRP.IsExists(profile))
                {
                    _uow.BrandInformationRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        response.IsSuccess = true;
                        response.Message = "Successfully added record.";
                        response.ReturnedObject = profile;
                    }
                }
                else
                {
                    response.IsSuccess = false;
                    response.Message = "User Information exist.";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.IsSuccess = false;
            }

            return response;
        }
        private async Task<GenericResponse<BrandInformation>> Update(int id, BrandInformation obj)
        {
            GenericResponse<BrandInformation> response = new GenericResponse<BrandInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.BrandInformationRP.GetById(id);
                objEx.brandname = obj.brandname != string.Empty || obj.brandname != null ? obj.brandname : objEx.brandname;
                objEx.isActive = obj.isActive;
                //objEx.ID = Id;
                _uow.BrandInformationRP.Update(objEx);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    response.IsSuccess = true;
                    response.Message = "Successfully updated record";
                    response.ReturnedObject = objEx;
                }
                //if (!await _uow.BrandInformationRP.IsExists(obj))
                //{
                //    objEx.brandname = obj.brandname != string.Empty || obj.brandname != null ? obj.brandname : objEx.brandname;
                //    //objEx.ID = Id;
                //    _uow.BrandInformationRP.Update(objEx);
                //    int result = await _uow.Complete();
                //    if (result > 0)
                //    {
                //        response.IsSuccess = true;
                //        response.Message = "Successfully updated record";
                //        response.Data = objEx;
                //    }
                //}
                //else
                //{
                //    response.Message = "Information already exist.";
                //}
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
