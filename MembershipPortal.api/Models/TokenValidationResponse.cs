using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Models
{
    public class TokenValidationResponse
    {
        public string tokenkey { get; set; }
        public string message { get; set; }
        public bool istokenvalid { get; set; }
        public bool istokenexpired { get; set; }
    }
}
