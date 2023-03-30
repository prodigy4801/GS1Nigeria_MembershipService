using MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{

    public class GTINRequestVM
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
        public DateTime approvaldate { get; set; }
        public Boolean isgcpassigned { get; set; }
        public DateTime assigneddate { get; set; }
        public string assignedby { get; set; }
        public string requesttype { get; set; }
        public int imagerequest_id { get; set; }
        public DateTime createdon { get; set; }
        public DateTime updatedon { get; set; }

        public CompanyVM Companies { get; set; }
        public GTINFeeVM GTINFee { get; set; }
    }

    public class GTINRequestVM_Create
    {
        [Required]
        public string registrationid { get; set; }
        [Required]
        public int gtinfee_id { get; set; }
        public double totalcost { get; set; } = 0.0;
        public int? imagerequestcount { get; set; }
    }
}
