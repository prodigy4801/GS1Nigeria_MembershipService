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
        private string[] _includes = { };

        public PackageLevelSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<PackageLevel>> GetAll()
        {
            try
            {
                var records = await _uow.PackageLevelRP.GetAll();
                return new GenericResponseList<PackageLevel> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<PackageLevel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<PackageLevel>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.PackageLevelRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<PackageLevel> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<PackageLevel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PackageLevel>> GetByID(int id)
        {
            try
            {
                var record = await _uow.PackageLevelRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<PackageLevel> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PackageLevel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PackageLevel>> GetByLevelName(string levelname)
        {
            try
            {
                var record = await _uow.PackageLevelRP.GetByFirstOrDefault(x => x.name == levelname, _includes);
                return new GenericResponse<PackageLevel> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PackageLevel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PackageLevel>> Remove(PackageLevel obj)
        {

            try
            {
                _uow.PackageLevelRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<PackageLevel> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<PackageLevel> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PackageLevel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PackageLevel>> Remove(int id)
        {

            try
            {
                var obj = _uow.PackageLevelRP.GetById(id);
                _uow.PackageLevelRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<PackageLevel> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<PackageLevel> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PackageLevel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PackageLevel>> Save(PackageLevel profile)
        {
            if (profile.id == 0)
            {
                return await Add(profile);
            }
            else
            {
                return await Update(profile.id, profile);
            }
        }

        private async Task<GenericResponse<PackageLevel>> Add(PackageLevel profile)
        {
            try
            {
                if (!await _uow.PackageLevelRP.AnyAsync(y => y.name == profile.name))
                {
                    _uow.PackageLevelRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<PackageLevel> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<PackageLevel> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<PackageLevel> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<PackageLevel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<PackageLevel>> Update(int id, PackageLevel obj)
        {

            try
            {
                _uow.PackageLevelRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<PackageLevel> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<PackageLevel> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PackageLevel> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
