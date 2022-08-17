using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Models
{
    public class ServiceResponse<T> where T : class
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public T ReturnedObject { get; set; }
    }
}
