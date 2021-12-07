﻿using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.core.Repository
{
    public interface IPackageLevelRepo : IGenericRepository<PackageLevel>
    {
        Task<bool> IsExists(PackageLevel profile);
    }
}
