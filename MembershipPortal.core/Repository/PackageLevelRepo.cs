using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class PackageLevelRepo : GenericRepository<PackageLevel>, IPackageLevelRepo
    {
        public PackageLevelRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(PackageLevel profile)
        {
            PackageLevel response = null;
            try
            {
                response = await ApplicationDBContext.PackageLevels.FirstOrDefaultAsync<PackageLevel>(m => m.level == profile.level);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }
    }
}
