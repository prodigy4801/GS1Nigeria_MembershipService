using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.data;
using MembershipPortal.data.ExternalEntries.Models;

namespace MembershipPortal.core.Repository
{
    public interface IUserRepo : IGenericRepository<UserModel>
    {
    }
}
