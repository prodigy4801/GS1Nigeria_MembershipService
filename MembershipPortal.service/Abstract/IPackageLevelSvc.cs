﻿using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IPackageLevelSvc : IService<PackageLevel>
    {
        Task<GenericResponse<PackageLevel>> GetByLevelName(string levelname);
    }
}
