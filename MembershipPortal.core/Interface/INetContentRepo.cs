using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.core.Repository
{
    public interface INetContentRepo : IGenericRepository<NetContent>
    {
        Task<bool> IsExists(NetContent profile);
    }
}
