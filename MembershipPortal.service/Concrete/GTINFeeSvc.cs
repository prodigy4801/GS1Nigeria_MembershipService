using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;
using MembershipPortal.data.ExternalEntries.Models;

namespace MembershipPortal.service.Concrete
{
    public class GTINFeeSvc : IGTINFeeSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public GTINFeeSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<GTINFee>> GetAll(int skip, int take)
        {
            try
            {
                var records = await _uow.GTINFeeRP.GetBy(null, null, skip, take, _includes);
                return new GenericResponseList<GTINFee> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GTINFee> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponseList<GTINFee>> GetAll()
        {
            try
            {
                var records = await _uow.GTINFeeRP.GetBy(null, y => y.OrderByDescending(y => y.ID), null, null, _includes);
                return new GenericResponseList<GTINFee> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<GTINFee> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINFee>> GetByID(int id)
        {
            try
            {
                var record = await _uow.GTINFeeRP.GetBySingleOrDefault(x => x.ID == id, _includes);
                return new GenericResponse<GTINFee> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINFee> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINFee>> GetByNumberOfGTIN(int numberofgtin)
        {
            try
            {
                var record = await _uow.GTINFeeRP.GetByFirstOrDefault(x => x.NumberOfGtins == numberofgtin, _includes); ;
                return new GenericResponse<GTINFee> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINFee> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINFee>> Remove(GTINFee obj)
        {
            try
            {
                _uow.GTINFeeRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GTINFee> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<GTINFee> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINFee> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINFee>> Remove(int id)
        {
            try
            {
                var obj = _uow.GTINFeeRP.GetById(id);
                _uow.GTINFeeRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GTINFee> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<GTINFee> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINFee> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<GTINFee>> Save(GTINFee profile)
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

        private async Task<GenericResponse<GTINFee>> Add(GTINFee profile)
        {
            try
            {
                if (!await _uow.GTINFeeRP.AnyAsync(y => y.NumberOfGtins == profile.NumberOfGtins))
                {
                    _uow.GTINFeeRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<GTINFee> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<GTINFee> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }
                else
                {
                    return new GenericResponse<GTINFee> { ReturnedObject = null, IsSuccess = false, Message = "User Information exist." };
                }

            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINFee> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        private async Task<GenericResponse<GTINFee>> Update(int id, GTINFee obj)
        {
            try
            {
                _uow.GTINFeeRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<GTINFee> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<GTINFee> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<GTINFee> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
