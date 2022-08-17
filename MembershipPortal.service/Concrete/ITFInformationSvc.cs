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

        public ITFInformationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<ITFInformation>> GetAll()
        {
            return await _uow.ITFInformationRP.GetAllAsync();
        }

        public async Task<ITFInformation> GetByID(int id)
        {
            return await _uow.ITFInformationRP.GetByIdAsync(id);
        }

        public async Task<GenericResponse<ITFInformation>> Remove(ITFInformation obj)
        {
            GenericResponse<ITFInformation> response = new GenericResponse<ITFInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.ITFInformationRP.Delete(obj);
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

        public async Task<GenericResponse<ITFInformation>> Remove(int id)
        {
            GenericResponse<ITFInformation> response = new GenericResponse<ITFInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.ITFInformationRP.GetById(id);
                _uow.ITFInformationRP.Delete(obj);
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
            GenericResponse<ITFInformation> response = new GenericResponse<ITFInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.ITFInformationRP.IsExists(profile))
                {
                    _uow.ITFInformationRP.Add(profile);
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
        private async Task<GenericResponse<ITFInformation>> Update(int id, ITFInformation obj)
        {
            GenericResponse<ITFInformation> response = new GenericResponse<ITFInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.ITFInformationRP.GetById(id);
                objEx.companyprefix = obj.companyprefix != string.Empty || obj.companyprefix != null ? obj.companyprefix : objEx.companyprefix;
                objEx.itf14 = obj.itf14 != string.Empty || obj.itf14 != null ? obj.itf14 : objEx.itf14;
                //objEx.ID = Id;
                _uow.ITFInformationRP.Update(objEx);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    response.IsSuccess = true;
                    response.Message = "Successfully updated record";
                    response.ReturnedObject = objEx;
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
