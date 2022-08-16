using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class ServiceResponseVM<T> where T : class
    {
        public T ReturnedObject { get; set; }
        public string Message { get; set; }
        public Boolean IsSuccess { get; set; }
    }
}
