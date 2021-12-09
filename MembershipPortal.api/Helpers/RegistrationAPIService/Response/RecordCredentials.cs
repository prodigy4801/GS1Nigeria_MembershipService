using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Helpers.RegistrationAPIService.Response
{
    public class RecordCredentials
    {
        public int id { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool activeStatus { get; set; }
    }
}
