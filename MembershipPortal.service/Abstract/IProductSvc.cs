﻿using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IProductSvc : IService<Product>
    {
        Task<GenericResponse<List<Product>>> SaveProductList(IEnumerable<Product> products);
    }
}
