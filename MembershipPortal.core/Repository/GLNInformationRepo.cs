using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class GLNInformationRepo : GenericRepository<GLNInformation>, IGLNInformationRepo
    {
        public GLNInformationRepo(ApplicationDBContext context) : base(context)
        {

        }
        public ApplicationDBContext ApplicationDBContext
        {
            get { return _context as ApplicationDBContext; }
        }

        public async Task<bool> IsExists(GLNInformation profile)
        {
            GLNInformation response = null;
            try
            {
                response = await ApplicationDBContext.GLNInformations.FirstOrDefaultAsync<GLNInformation>(m => m.gln == profile.gln);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return response != null ? true : false;
        }
    }
}
