using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class GCPInformationRepo : GenericRepository<GCPInformation>, IGCPInformationRepo
    {
        public GCPInformationRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
