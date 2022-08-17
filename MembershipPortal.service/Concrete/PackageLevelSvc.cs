using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class PackageLevelSvc : IPackageLevelSvc
    {
        private readonly IUnitOfWork _uow;

        public PackageLevelSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<PackageLevel>> GetAll()
        {
            return await _uow.PackageLevelRP.GetAllAsync();
        }

        public async Task<PackageLevel> GetByID(int id)
        {
            return await _uow.PackageLevelRP.GetByIdAsync(id);
        }

        public async Task<PackageLevel> GetByPackageLevelName(string name)
        {
            return await _uow.PackageLevelRP.GetSingleByAsync(s => s.name == name);
        }

        public async Task<GenericResponse<PackageLevel>> Remove(PackageLevel obj)
        {
            GenericResponse<PackageLevel> response = new GenericResponse<PackageLevel>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.PackageLevelRP.Delete(obj);
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

        public async Task<GenericResponse<PackageLevel>> Remove(int id)
        {
            GenericResponse<PackageLevel> response = new GenericResponse<PackageLevel>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.PackageLevelRP.GetById(id);
                _uow.PackageLevelRP.Delete(obj);
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

        public async Task<GenericResponse<PackageLevel>> Save(PackageLevel profile)
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

        private async Task<GenericResponse<PackageLevel>> Add(PackageLevel profile)
        {
            GenericResponse<PackageLevel> response = new GenericResponse<PackageLevel>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.PackageLevelRP.IsExists(profile))
                {
                    _uow.PackageLevelRP.Add(profile);
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
        private async Task<GenericResponse<PackageLevel>> Update(int id, PackageLevel obj)
        {
            GenericResponse<PackageLevel> response = new GenericResponse<PackageLevel>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.PackageLevelRP.GetById(id);
                objEx.name = obj.name != string.Empty || obj.name != null ? obj.name : objEx.name;
                objEx.description = obj.description != string.Empty || obj.description != null ? obj.description : objEx.description;
                //objEx.ID = Id;
                _uow.PackageLevelRP.Update(objEx);
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
