using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data.ExternalEntries.Models
{
    public class ImageRequestModel
    {
        public int id { get; set; }
        public string imagetype { get; set; }
        public string registrationid { get; set; }
        public int imagecount { get; set; }
        public Boolean isapproved { get; set; }
        public string approvedby { get; set; }
        public DateTime createdon { get; set; }
        public DateTime updatedon { get; set; }
    }
}
