using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.core.Repository
{
    public class CompanyRepo : GenericRepository<Company>, ICompanyRepo
    {
        public CompanyRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
