using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.core.Repository
{
    public interface IProductRepo : IGenericRepository<Product>
    {
        Task<bool> IsExists(Product profile);
    }
}
