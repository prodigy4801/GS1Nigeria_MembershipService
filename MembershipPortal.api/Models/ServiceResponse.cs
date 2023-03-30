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

    public class GeneralResponse<T>
    {
        public string Message { get; set; }

        public T ReturnedObject { get; set; }
    }

    public class ServiceResponseList<T> where T : class
    {
        public bool IsSuccess { get; set; } = false;
        public string Message { get; set; } = string.Empty;

        public List<T> ReturnedObject { get; set; } = null;
    }

    public class ExternalServiceResponseList<T> where T : class
    {
        public int Status { get; set; }
        public List<string> Message { get; set; }
        public List<string> BadData { get; set; }

        public List<T> ReturnedObject { get; set; }
    }
}
