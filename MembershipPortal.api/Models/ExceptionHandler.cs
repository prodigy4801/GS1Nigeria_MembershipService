using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MembershipPortal.api.Models
{
    public class CustomErrorHandler
    {
        public int statuscode { get; set; }
        public string message { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
