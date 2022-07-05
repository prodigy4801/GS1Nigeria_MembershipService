using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class BrandInformationRepo : GenericRepository<BrandInformation>, IBrandInformationRepo
    {
        public BrandInformationRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(BrandInformation profile)
        {
            BrandInformation response = null;
            try
            {
                response = await ApplicationDBContext.BrandInformations.FirstOrDefaultAsync<BrandInformation>(m => m.brandname == profile.brandname);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }
    }
}
