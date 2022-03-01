using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class BrickCategorySvc : IBrickCategorySvc
    {
        private readonly IUnitOfWork _uow;

        public BrickCategorySvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<BrickCategory>> GetAll()
        {
            return await _uow.BrickCategoryRP.GetAllAsync();
        }

        public async Task<BrickCategory> GetByID(int id)
        {
            return await _uow.BrickCategoryRP.GetByIdAsync(id);
        }

        public async Task<GenericResponse<BrickCategory>> Remove(BrickCategory obj)
        {
            GenericResponse<BrickCategory> response = new GenericResponse<BrickCategory>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.BrickCategoryRP.Delete(obj);
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

        public async Task<GenericResponse<BrickCategory>> Remove(int id)
        {
            GenericResponse<BrickCategory> response = new GenericResponse<BrickCategory>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.BrickCategoryRP.GetById(id);
                _uow.BrickCategoryRP.Delete(obj);
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

        public async Task<GenericResponse<BrickCategory>> Save(BrickCategory profile)
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

        private async Task<GenericResponse<BrickCategory>> Add(BrickCategory profile)
        {
            GenericResponse<BrickCategory> response = new GenericResponse<BrickCategory>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.BrickCategoryRP.IsExists(profile))
                {
                    _uow.BrickCategoryRP.Add(profile);
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
        private async Task<GenericResponse<BrickCategory>> Update(int id, BrickCategory obj)
        {
            GenericResponse<BrickCategory> response = new GenericResponse<BrickCategory>
            {
                Data = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.BrickCategoryRP.GetById(id);
                objEx.brick = obj.brick != string.Empty || obj.brick != null ? obj.brick : objEx.brick;
                objEx.brick_id = obj.brick_id != string.Empty || obj.brick_id != null ? obj.brick_id : objEx.brick_id;

                //objEx.ID = Id;
                _uow.BrickCategoryRP.Update(objEx);
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
