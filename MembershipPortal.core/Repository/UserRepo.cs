using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using MembershipPortal.data.ExternalEntries.Models;
using Microsoft.EntityFrameworkCore;

namespace MembershipPortal.core.Repository
{
    public class UserRepo : GenericRepository<UserModel>, IUserRepo
    {
        public UserRepo(ApplicationDBContext context) : base(context)
        {

        }
    }
}
