using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.core
{
    public class GenericResponse<T> where T : class
    {
        public bool status { get; set; }
        public string message { get; set; }
        public T returnedData { get; set; }
    }

    public class GenericResponseList<T> where T : class
    {
        public bool status { get; set; }
        public string message { get; set; }
        public List<T> returnedData { get; set; }
    }
}
