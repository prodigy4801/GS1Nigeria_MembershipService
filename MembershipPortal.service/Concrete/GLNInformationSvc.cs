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
        private readonly string[] _includeProps = new string[] { "Product" };

        public GLNInformationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<GLNInformation>> GetAll()
        {
            return await _uow.GLNInformationRP.GetAllAsync();
        }

        public async Task<GLNInformation> GetByID(int id)
        {
            return await _uow.GLNInformationRP.GetByIdAsync(id);
        }

        public async Task<GenericResponse<GLNInformation>> Remove(GLNInformation obj)
        {
            GenericResponse<GLNInformation> response = new GenericResponse<GLNInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.GLNInformationRP.Delete(obj);
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

        public async Task<GenericResponse<GLNInformation>> Remove(int id)
        {
            GenericResponse<GLNInformation> response = new GenericResponse<GLNInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.GLNInformationRP.GetById(id);
                _uow.GLNInformationRP.Delete(obj);
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
            GenericResponse<GLNInformation> response = new GenericResponse<GLNInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.GLNInformationRP.IsExists(profile))
                {
                    _uow.GLNInformationRP.Add(profile);
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
        private async Task<GenericResponse<GLNInformation>> Update(int id, GLNInformation obj)
        {
            GenericResponse<GLNInformation> response = new GenericResponse<GLNInformation>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.GLNInformationRP.GetById(id);
                objEx.companyprefix = obj.companyprefix != string.Empty || obj.companyprefix != null ? obj.companyprefix : objEx.companyprefix;
                objEx.gln = obj.gln != string.Empty || obj.gln != null ? obj.gln : objEx.gln;
                //objEx.ID = Id;
                _uow.GLNInformationRP.Update(objEx);
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
