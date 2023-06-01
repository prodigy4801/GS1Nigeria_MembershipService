using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class ImageBankUsage
    {
        public int id { get; set; }
        public string registrationid { get; set; }
        public string gtin { get; set; }
        public int downloadCount { get; set; } = 0;
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
