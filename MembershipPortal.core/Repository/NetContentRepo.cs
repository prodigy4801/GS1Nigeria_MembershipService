using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class NetContentRepo : GenericRepository<NetContent>, INetContentRepo
    {
        public NetContentRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(NetContent profile)
        {
            NetContent response = null;
            try
            {
                response = await ApplicationDBContext.NetContents.FirstOrDefaultAsync<NetContent>(m => m.name == profile.name);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }
    }
}
