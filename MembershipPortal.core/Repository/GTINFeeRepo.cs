using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class GTINFeeRepo : GenericRepository<GTINFee>, IGTINFeeRepo
    {
        public GTINFeeRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
