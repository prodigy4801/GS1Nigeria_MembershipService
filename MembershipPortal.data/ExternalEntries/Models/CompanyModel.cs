using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data.ExternalEntries.Models
{
    public class CompanyModel
    {
        public int id { get; set; }
        public string companyname { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        public string registrationid { get; set; }
        public string companyaddress { get; set; }
        public string factoryaddress { get; set; }
        public DateTime? registrationdate { get; set; }
        public DateTime? dateofincorporation { get; set; }
        public string cacnumber { get; set; }
        public Boolean isregistrationcompleted { get; set; }
        public Boolean approvalstatus { get; set; }
        public DateTime createdon { get; set; }
        public DateTime modifiedon { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime DateOfApproval { get; set; }
    }
}
