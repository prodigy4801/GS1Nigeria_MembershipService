using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data.ExternalEntries.Models
{
    public class GTINRequestModel
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public string registrationid { get; set; }
        public int gtinfee_id { get; set; }
        public int gtincount { get; set; }
        public double totalcost { get; set; }
        public DateTime dateofrequest { get; set; }
        public Boolean isapproved { get; set; }
        public string approvedby { get; set; }
        public Boolean isgcpassigned { get; set; }
        public int? imagerequest_id { get; set; }
        public DateTime createdon { get; set; }
        public DateTime updatedon { get; set; }
        public CompanyModel Companies { get; set; }
        public GTINFee GTINFee { get; set; }
        public ImageRequestModel ImageRequest { get; set; }
    }

    public class GTINRequestModel_Create
    {
        [Required]
        public string registrationid { get; set; }
        [Required]
        public int gtinfee_id { get; set; }
        public double totalcost { get; set; }
        public int? imagerequestcount { get; set; }

    }
}
