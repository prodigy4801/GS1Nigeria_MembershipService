using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IProductTargetMarketSvc : IService<ProductTargetMarket>
    {
        Task<GenericResponseList<ProductTargetMarket>> GetAll(int? skip, int? take);
        Task<GenericResponseList<ProductTargetMarket>> GetByRegistrationID(string regId);
        Task<GenericResponseList<ProductTargetMarket>> GetByProductRegistrationID(int prodId, string regId);
        Task<bool> IsExist(int prodId, string regId, int targetMarketID);
    }
}
