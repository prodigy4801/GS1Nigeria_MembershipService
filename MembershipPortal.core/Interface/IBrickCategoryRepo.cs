using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;

namespace MembershipPortal.core.Repository
{
    public interface IBrickCategoryRepo : IGenericRepository<BrickCategory>
    {
        Task<bool> IsExists(BrickCategory profile);
    }
}
