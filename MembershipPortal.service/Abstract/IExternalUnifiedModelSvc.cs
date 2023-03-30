using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IExternalUnifiedModelSvc : IService<ExternalUnifiedModel>
    {
        Task<GenericResponseList<ExternalUnifiedModel>> GetAll(int? skip, int? take);
        Task<GenericResponse<ExternalUnifiedModel>> GetByProductID(int productId);
        Task<GenericResponse<bool>> IsExist(ExternalUnifiedModel profile);
    }
}
