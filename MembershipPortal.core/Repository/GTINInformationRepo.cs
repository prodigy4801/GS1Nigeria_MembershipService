using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class GTINInformationRepo : GenericRepository<GTINInformation>, IGTINInformationRepo
    {
        public GTINInformationRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(GTINInformation profile)
        {
            GTINInformation response = null;
            try
            {
                response = await ApplicationDBContext.GTINInformations.FirstOrDefaultAsync<GTINInformation>(m => m.gtin == profile.gtin);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }
    }
}
