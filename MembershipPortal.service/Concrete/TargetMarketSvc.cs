using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class TargetMarketSvc : ITargetMarketSvc
    {
        private readonly IUnitOfWork _uow;

        public TargetMarketSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<TargetMarket>> GetAll()
        {
            return await _uow.TargetMarketRP.GetAllAsync();
        }

        public async Task<TargetMarket> GetByID(int id)
        {
            return await _uow.TargetMarketRP.GetByIdAsync(id);
        }

        public async Task<TargetMarket> GetByTargetMarketName(string name)
        {
            return await _uow.TargetMarketRP.GetSingleByAsync(s => s.name == name);
        }

        public async Task<GenericResponse<TargetMarket>> Remove(TargetMarket obj)
        {
            GenericResponse<TargetMarket> response = new GenericResponse<TargetMarket>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.TargetMarketRP.Delete(obj);
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

        public async Task<GenericResponse<TargetMarket>> Remove(int id)
        {
            GenericResponse<TargetMarket> response = new GenericResponse<TargetMarket>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.TargetMarketRP.GetById(id);
                _uow.TargetMarketRP.Delete(obj);
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

        public async Task<GenericResponse<TargetMarket>> Save(TargetMarket profile)
        {
            if (profile.id == 0)
            {
                //profile.create = DateTime.Now;

                return await Add(profile);
            }
            else
            {
                //profile.modifiedon = DateTime.Now;
                return await Update(profile.id, profile);
            }
        }

        private async Task<GenericResponse<TargetMarket>> Add(TargetMarket profile)
        {
            GenericResponse<TargetMarket> response = new GenericResponse<TargetMarket>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.TargetMarketRP.IsExists(profile))
                {
                    _uow.TargetMarketRP.Add(profile);
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
        private async Task<GenericResponse<TargetMarket>> Update(int id, TargetMarket obj)
        {
            GenericResponse<TargetMarket> response = new GenericResponse<TargetMarket>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.TargetMarketRP.GetById(id);
                objEx.name = obj.name != string.Empty || obj.name != null ? obj.name : objEx.name;
                
                //objEx.ID = Id;
                _uow.TargetMarketRP.Update(objEx);
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
