using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Helpers.RegistrationAPIService.Response
{
    public class GenerateTokenResponse
    {
        public int id { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string jwtToken { get; set; }
    }
}
