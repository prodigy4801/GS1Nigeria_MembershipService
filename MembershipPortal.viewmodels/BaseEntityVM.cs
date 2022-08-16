using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class BaseEntityVM
    {
        public int id { get; set; }
        public DateTimeOffset createdon { get; set; }
        public DateTimeOffset modifiedon { get; set; }
    }
}
