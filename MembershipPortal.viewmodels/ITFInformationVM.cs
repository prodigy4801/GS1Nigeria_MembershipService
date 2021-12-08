using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class ITFInformationVM
    {
        public int id { get; set; }
        public string registrationid { get; set; }
        public string itf14 { get; set; }
        public string companyprefix { get; set; }
        public DateTime createddate { get; set; }
        public DateTime? modifieddate { get; set; }
    }

    public class ITFInformationVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string registrationid { get; set; }
        [Required]
        [StringLength(50)]
        public string itf14 { get; set; }
        [StringLength(50)]
        public string companyprefix { get; set; }
    }
}
