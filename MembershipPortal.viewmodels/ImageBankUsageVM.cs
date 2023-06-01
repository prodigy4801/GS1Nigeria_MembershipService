using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class ImageBankUsageVM
    {
        public string registrationid { get; set; }
        public string gtin { get; set; }
        public int downloadCount { get; set; } = 0;
    }
}
