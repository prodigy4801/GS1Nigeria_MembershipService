using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class TargetMarketRepo : GenericRepository<TargetMarket>, ITargetMarketRepo
    {
        public TargetMarketRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(TargetMarket profile)
        {
            TargetMarket response = null;
            try
            {
                response = await ApplicationDBContext.TargetMarkets.FirstOrDefaultAsync<TargetMarket>(m => m.name == profile.name);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }
    }
}
