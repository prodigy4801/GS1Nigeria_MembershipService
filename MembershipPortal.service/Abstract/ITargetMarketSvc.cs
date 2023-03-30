using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface ITargetMarketSvc : IService<TargetMarket>
    {
        Task<GenericResponse<TargetMarket>> GetByMarketName(string marketname);
    }
}
