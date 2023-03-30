using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class PharmaceuticalInformationSvc : IPharmaceuticalInformationSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public PharmaceuticalInformationSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<PharmaceuticalInformation>> GetAll()
        {
            try
            {
                var records = await _uow.PharmaceuticalInformationRP.GetBy(null, x => x.OrderByDescending(y => y.ID), null, null, _includes);
                return new GenericResponseList<PharmaceuticalInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<PharmaceuticalInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<PharmaceuticalInformation>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.PharmaceuticalInformationRP.GetBy(null, x => x.OrderByDescending(y => y.ID), skip, take, _includes);
                return new GenericResponseList<PharmaceuticalInformation> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<PharmaceuticalInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PharmaceuticalInformation>> GetByID(int id)
        {
            try
            {
                var record = await _uow.PharmaceuticalInformationRP.GetByFirstOrDefault(x => x.ID == id, _includes);
                return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PharmaceuticalInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PharmaceuticalInformation>> GetByProductID(int productId)
        {
            try
            {
                var record = await _uow.PharmaceuticalInformationRP.GetBySingleOrDefault(x => x.ProductID == productId, _includes); ;
                return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PharmaceuticalInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PharmaceuticalInformation>> Remove(PharmaceuticalInformation obj)
        {

            try
            {
                _uow.PharmaceuticalInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PharmaceuticalInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PharmaceuticalInformation>> Remove(int id)
        {

            try
            {
                var obj = _uow.PharmaceuticalInformationRP.GetById(id);
                _uow.PharmaceuticalInformationRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PharmaceuticalInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<PharmaceuticalInformation>> Save(PharmaceuticalInformation profile)
        {
            if (profile.ID == 0)
            {
                return await Add(profile);
            }
            else
            {
                return await Update(profile.ID, profile);
            }
        }

        private async Task<GenericResponse<PharmaceuticalInformation>> Add(PharmaceuticalInformation profile)
        {
            try
            {
                if (!await _uow.PharmaceuticalInformationRP.AnyAsync(y => y.ProductID == profile.ProductID && y.ProductForm == profile.ProductForm))
                {
                    _uow.PharmaceuticalInformationRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<PharmaceuticalInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<PharmaceuticalInformation>> Update(int id, PharmaceuticalInformation obj)
        {

            try
            {
                _uow.PharmaceuticalInformationRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<PharmaceuticalInformation> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<PharmaceuticalInformation> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
