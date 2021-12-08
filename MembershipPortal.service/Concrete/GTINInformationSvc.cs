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

        public GTINInformationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<GTINInformation>> GetAll()
        {
            return await _uow.GTINInformationRP.GetAllAsync();
        }

        public async Task<GTINInformation> GetByID(int id)
        {
            return await _uow.GTINInformationRP.GetByIdAsync(id);
        }

        public async Task<GenericResponse<GTINInformation>> Remove(GTINInformation obj)
        {
            GenericResponse<GTINInformation> response = new GenericResponse<GTINInformation>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.GTINInformationRP.Delete(obj);
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

        public async Task<GenericResponse<GTINInformation>> Remove(int id)
        {
            GenericResponse<GTINInformation> response = new GenericResponse<GTINInformation>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.GTINInformationRP.GetById(id);
                _uow.GTINInformationRP.Delete(obj);
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
            GenericResponse<GTINInformation> response = new GenericResponse<GTINInformation>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.GTINInformationRP.IsExists(profile))
                {
                    _uow.GTINInformationRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        response.IsSuccess = true;
                        response.Message = "Successfully added record.";
                        response.Data = profile;
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
        private async Task<GenericResponse<GTINInformation>> Update(int id, GTINInformation obj)
        {
            GenericResponse<GTINInformation> response = new GenericResponse<GTINInformation>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.GTINInformationRP.GetById(id);
                objEx.checksum = obj.checksum > 0 ? obj.checksum : objEx.checksum;
                objEx.companyprefix = obj.companyprefix != string.Empty || obj.companyprefix != null ? obj.companyprefix : objEx.companyprefix;
                objEx.gtin = obj.gtin != string.Empty || obj.gtin != null ? obj.gtin : objEx.gtin;
                objEx.productcode = obj.productcode != string.Empty || obj.productcode != null ? obj.productcode : objEx.productcode;
                //objEx.ID = Id;
                _uow.GTINInformationRP.Update(objEx);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    response.IsSuccess = true;
                    response.Message = "Successfully updated record";
                    response.Data = objEx;
                }
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
