using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service.Models
{
    public class GCPInformationSvcModel
    {
        public string CompanyPrefix { get; set; }
        public int GtinCount { get; set; }
        public int MaxGtin { get; set; }
        public bool Active { get; set; }
    }
}
