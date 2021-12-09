using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Helpers.RegistrationAPIService.Request
{
    public class ValidateTokenRequest
    {
        public string token { get; set; }
        public string securityKey { get; set; }
    }
}
