using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class ITFInformationRepo : GenericRepository<ITFInformation>, IITFInformationRepo
    {
        public ITFInformationRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(ITFInformation profile)
        {
            ITFInformation response = null;
            try
            {
                response = await ApplicationDBContext.ITFInformations.FirstOrDefaultAsync<ITFInformation>(m => m.itf14 == profile.itf14);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }
    }
}
