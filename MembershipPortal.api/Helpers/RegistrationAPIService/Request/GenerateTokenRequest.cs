﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Helpers.RegistrationAPIService.Request
{
    public class GenerateTokenRequest
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
