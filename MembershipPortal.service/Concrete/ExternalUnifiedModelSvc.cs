using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class ExternalUnifiedModelSvc : IExternalUnifiedModelSvc
    {
        private readonly IUnitOfWork _uow;
        private readonly string[] _includeProps = new string[] { "Product" };

        public ExternalUnifiedModelSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<ExternalUnifiedModel>> GetAll()
        {
            return await _uow.ExternalUnifiedModelRP.GetBy(null, x => x.OrderByDescending(n => n.id), null, null, _includeProps);
        }

        public async Task<ExternalUnifiedModel> GetByID(int id)
        {
            return await _uow.ExternalUnifiedModelRP.GetByFirstOrDefault(x => x.id == id, _includeProps);
        }

        public async Task<GenericResponse<ExternalUnifiedModel>> Remove(ExternalUnifiedModel obj)
        {
            GenericResponse<ExternalUnifiedModel> response = new GenericResponse<ExternalUnifiedModel>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                _uow.ExternalUnifiedModelRP.Delete(obj);
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

        public async Task<GenericResponse<ExternalUnifiedModel>> Remove(int id)
        {
            GenericResponse<ExternalUnifiedModel> response = new GenericResponse<ExternalUnifiedModel>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var obj = _uow.ExternalUnifiedModelRP.GetById(id);
                _uow.ExternalUnifiedModelRP.Delete(obj);
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

        public async Task<GenericResponse<ExternalUnifiedModel>> Save(ExternalUnifiedModel profile)
        {
            if (profile.id == 0)
            {
                profile.datecreated = DateTime.UtcNow;
                return await Add(profile);
            }
            else
            {
                profile.datemodified = DateTime.UtcNow;
                return await Update(profile.id, profile);
            }
        }

        private async Task<GenericResponse<ExternalUnifiedModel>> Add(ExternalUnifiedModel profile)
        {
            GenericResponse<ExternalUnifiedModel> response = new GenericResponse<ExternalUnifiedModel>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                if (!await _uow.ExternalUnifiedModelRP.IsExists(profile))
                {
                    _uow.ExternalUnifiedModelRP.Add(profile);
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
        private async Task<GenericResponse<ExternalUnifiedModel>> Update(int id, ExternalUnifiedModel obj)
        {
            GenericResponse<ExternalUnifiedModel> response = new GenericResponse<ExternalUnifiedModel>
            {
                ReturnedObject = null,
                IsSuccess = false,
                Message = string.Empty
            };
            try
            {
                var objEx = _uow.ExternalUnifiedModelRP.GetById(id);
                objEx.atccode = obj.atccode != string.Empty || obj.atccode != null ? obj.atccode : objEx.atccode;
                objEx.functionalname = obj.functionalname != string.Empty || obj.functionalname != null ? obj.functionalname : objEx.functionalname;
                objEx.genericname = obj.genericname != string.Empty || obj.genericname != null ? obj.genericname : objEx.genericname;
                objEx.labeldescription = obj.labeldescription != string.Empty || obj.labeldescription != null ? obj.labeldescription : objEx.labeldescription;
                objEx.modifiedby = obj.modifiedby;
                objEx.packsize = obj.packsize != string.Empty || obj.packsize != null ? obj.packsize : objEx.packsize;
                objEx.primarypackagingmaterial = obj.primarypackagingmaterial != string.Empty || obj.primarypackagingmaterial != null ? obj.primarypackagingmaterial : objEx.primarypackagingmaterial;
                objEx.productform = obj.productform != string.Empty || obj.productform != null ? obj.productform : objEx.productform;
                objEx.quantity = obj.quantity != string.Empty || obj.quantity != null ? obj.quantity : objEx.quantity;
                objEx.routeofadministration = obj.routeofadministration != string.Empty || obj.routeofadministration != null ? obj.routeofadministration : objEx.routeofadministration;
                objEx.shelflife = obj.shelflife != string.Empty || obj.shelflife != null ? obj.shelflife : objEx.shelflife;
                objEx.strength = obj.strength != string.Empty || obj.strength != null ? obj.strength : objEx.strength;
                objEx.tradeitemdescription = obj.tradeitemdescription != string.Empty || obj.tradeitemdescription != null ? obj.tradeitemdescription : objEx.tradeitemdescription;
                objEx.unitofmeasure = obj.unitofmeasure != string.Empty || obj.unitofmeasure != null ? obj.unitofmeasure : objEx.unitofmeasure;

                //objEx.ID = Id;
                _uow.ExternalUnifiedModelRP.Update(objEx);
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
