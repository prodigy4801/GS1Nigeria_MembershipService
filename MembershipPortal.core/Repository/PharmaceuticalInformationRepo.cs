using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class PharmaceuticalInformationRepo : GenericRepository<PharmaceuticalInformation>, IPharmaceuticalInformationRepo
    {
        public PharmaceuticalInformationRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
