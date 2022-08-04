using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class GLNRequestVM
    {
        public int id { get; set; }
        public string registrationid { get; set; }
        public int company_id { get; set; }
        public int glnfee_id { get; set; }
        public int glncount { get; set; }
        public DateTime issuancedate { get; set; }
        public Boolean isemailsent { get; set; }
        public int glntypeid { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string address { get; set; }
        public string department { get; set; }
        public string company_prefix { get; set; }
        public Boolean isapproved { get; set; }
        public string dateassigned { get; set; }
        public DateTime createdon { get; set; }
        public DateTime updatedon { get; set; }
        public CompanyVM Companies { get; set; }
        public GLNFeeVM GLNFee { get; set; }
    }

    public class GLNRequestVM_CRU
    {
        public int id { get; set; }
        [Required]
        public string registrationid { get; set; }
        [Required]
        public int company_id { get; set; }
        [Required]
        public int glnfee_id { get; set; }
        public int glncount { get; set; }
        public DateTime issuancedate { get; set; }
        public Boolean isemailsent { get; set; }
        public int glntypeid { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        [StringLength(500)]
        public string address { get; set; }
        public string department { get; set; }
        public string company_prefix { get; set; }
        public Boolean isapproved { get; set; }
        public string dateassigned { get; set; }
    }
}
