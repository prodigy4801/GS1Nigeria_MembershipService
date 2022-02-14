using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class PackagingTypeRepo : GenericRepository<PackagingType>, IPackagingTypeRepo
    {
        public PackagingTypeRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(PackagingType profile)
        {
            PackagingType response = null;
            try
            {
                response = await ApplicationDBContext.PackagingTypes.FirstOrDefaultAsync<PackagingType>(m => m.name == profile.name);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }
    }
}
