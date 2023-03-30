using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class ProductTargetMarketRepo : GenericRepository<ProductTargetMarket>, IProductTargetMarketRepo
    {
        public ProductTargetMarketRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
