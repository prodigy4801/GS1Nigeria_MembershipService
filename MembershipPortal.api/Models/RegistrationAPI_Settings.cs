using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Models
{
    public class RegistrationAPI_Settings
    {
        public string Key { get; set; }
        public string BaseUrl { get; set; }
        public string RegisterAPI { get; set; }
        public string TokenGenerator { get; set; }
        public string TokenValidator { get; set; }
    }
}
