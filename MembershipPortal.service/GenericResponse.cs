using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public class GenericResponse<T>
    {
        public T ReturnedObject { get; set; }
        public string Message { get; set; }
        public Boolean IsSuccess { get; set; }
    }

    public class GenericResponseList<T> where T : class
    {
        public IEnumerable<T> ReturnedObject { get; set; }
        //public List<string> BadData { get; set; }
        public string Message { get; set; }
        public Boolean IsSuccess { get; set; }
    }

    public class GenericServiceResponseList<T> where T : class
    {
        public IEnumerable<T> ReturnedObject { get; set; }
        public List<string> BadData { get; set; }
        public List<string> Message { get; set; }
        public Boolean IsSuccess { get; set; }
    }
}
