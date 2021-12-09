using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Helpers.RegistrationAPIService.Response
{
    public class RegistrationResponse
    {
        public RecordCredentials data { get; set; }
        public string message { get; set; }
        public bool isSuccess { get; set; }
    }
}
