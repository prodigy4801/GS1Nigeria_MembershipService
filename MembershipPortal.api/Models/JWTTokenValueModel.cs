using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Models
{
    public class JWTTokenValueModel
    {
        public string registrationID { get; set; }
        public string email { get; set; }
        public string companyname { get; set; }
    }
}
