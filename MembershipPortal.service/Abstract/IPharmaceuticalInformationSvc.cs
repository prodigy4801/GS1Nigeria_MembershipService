﻿using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IPharmaceuticalInformationSvc : IService<PharmaceuticalInformation>
    {
        Task<GenericResponse<PharmaceuticalInformation>> GetByProductID(int productId);
    }
}
