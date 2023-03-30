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
        private string[] _includes = { };

        public PackagingTypeSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<PackagingType>> GetAll()
        {
            try
            {
                var records = await _uow.PackagingTypeRP.GetAll();
                return new GenericResponseList<PackagingType> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<PackagingType> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<PackagingType>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.PackagingTypeRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<PackagingType> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<PackagingType> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PackagingType>> GetByID(int id)
        {
            try
            {
                var record = await _uow.PackagingTypeRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<PackagingType> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PackagingType> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PackagingType>> GetByTypeName(string typename)
        {
            try
            {
                var record = await _uow.PackagingTypeRP.GetByFirstOrDefault(x => x.name == typename, _includes);
                return new GenericResponse<PackagingType> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PackagingType> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PackagingType>> Remove(PackagingType obj)
        {

            try
            {
                _uow.PackagingTypeRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<PackagingType> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<PackagingType> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PackagingType> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PackagingType>> Remove(int id)
        {

            try
            {
                var obj = _uow.PackagingTypeRP.GetById(id);
                _uow.PackagingTypeRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<PackagingType> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<PackagingType> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PackagingType> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PackagingType>> Save(PackagingType profile)
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

        private async Task<GenericResponse<PackagingType>> Add(PackagingType profile)
        {
            try
            {
                if (!await _uow.PackagingTypeRP.AnyAsync(y => y.name == profile.name))
                {
                    _uow.PackagingTypeRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<PackagingType> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<PackagingType> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<PackagingType> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<PackagingType> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<PackagingType>> Update(int id, PackagingType obj)
        {

            try
            {
                _uow.PackagingTypeRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<PackagingType> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<PackagingType> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PackagingType> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
