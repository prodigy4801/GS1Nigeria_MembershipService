using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class NetContentSvc : INetContentSvc
    {
        private readonly IUnitOfWork _uow;

        public NetContentSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<NetContent>> GetAll()
        {
            return await _uow.NetContentRP.GetAllAsync();
        }

        public async Task<NetContent> GetByID(int id)
        {
            return await _uow.NetContentRP.GetByIdAsync(id);
        }

        public async Task<NetContent> GetByNetContentName(string name)
        {
            return await _uow.NetContentRP.GetSingleByAsync(s => s.name == name);
        }

        public async Task<GenericResponse<NetContent>> Remove(NetContent obj)
        {
            GenericResponse<NetContent> response = new GenericResponse<NetContent>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.NetContentRP.Delete(obj);
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

        public async Task<GenericResponse<NetContent>> Remove(int id)
        {
            GenericResponse<NetContent> response = new GenericResponse<NetContent>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.NetContentRP.GetById(id);
                _uow.NetContentRP.Delete(obj);
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

        public async Task<GenericResponse<NetContent>> Save(NetContent profile)
        {
            if (profile.id == 0)
            {
                //profile.createddate = DateTime.Now;

                return await Add(profile);
            }
            else
            {
                //profile.modifieddate = DateTime.Now;
                return await Update(profile.id, profile);
            }
        }

        private async Task<GenericResponse<NetContent>> Add(NetContent profile)
        {
            GenericResponse<NetContent> response = new GenericResponse<NetContent>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.NetContentRP.IsExists(profile))
                {
                    _uow.NetContentRP.Add(profile);
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
        private async Task<GenericResponse<NetContent>> Update(int id, NetContent obj)
        {
            GenericResponse<NetContent> response = new GenericResponse<NetContent>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.NetContentRP.GetById(id);
                objEx.code = obj.code != string.Empty || obj.code != null ? obj.code : objEx.code;
                objEx.description = obj.description != string.Empty || obj.description != null ? obj.description : objEx.description;
                objEx.name = obj.name != string.Empty || obj.name != null ? obj.name : objEx.name;
                //objEx.ID = Id;
                _uow.NetContentRP.Update(objEx);
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
