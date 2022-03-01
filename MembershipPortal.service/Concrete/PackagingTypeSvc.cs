using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class PackagingTypeSvc : IPackagingTypeSvc
    {
        private readonly IUnitOfWork _uow;

        public PackagingTypeSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<PackagingType>> GetAll()
        {
            return await _uow.PackagingTypeRP.GetAllAsync();
        }

        public async Task<PackagingType> GetByID(int id)
        {
            return await _uow.PackagingTypeRP.GetByIdAsync(id);
        }

        public async Task<PackagingType> GetByPackagingTypeName(string name)
        {
            return await _uow.PackagingTypeRP.GetSingleByAsync(s => s.name == name);
        }

        public async Task<GenericResponse<PackagingType>> Remove(PackagingType obj)
        {
            GenericResponse<PackagingType> response = new GenericResponse<PackagingType>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.PackagingTypeRP.Delete(obj);
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

        public async Task<GenericResponse<PackagingType>> Remove(int id)
        {
            GenericResponse<PackagingType> response = new GenericResponse<PackagingType>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.PackagingTypeRP.GetById(id);
                _uow.PackagingTypeRP.Delete(obj);
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

        public async Task<GenericResponse<PackagingType>> Save(PackagingType profile)
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

        private async Task<GenericResponse<PackagingType>> Add(PackagingType profile)
        {
            GenericResponse<PackagingType> response = new GenericResponse<PackagingType>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.PackagingTypeRP.IsExists(profile))
                {
                    _uow.PackagingTypeRP.Add(profile);
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
        private async Task<GenericResponse<PackagingType>> Update(int id, PackagingType obj)
        {
            GenericResponse<PackagingType> response = new GenericResponse<PackagingType>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.PackagingTypeRP.GetById(id);
                objEx.name = obj.name != string.Empty || obj.name != null ? obj.name : objEx.name;
                //objEx.ID = Id;
                _uow.PackagingTypeRP.Update(objEx);
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
