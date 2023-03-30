using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class GLNInformationVM
    {
        public int id { get; set; }
        public string registrationid { get; set; }
        public string gln { get; set; }
        public string companyprefix { get; set; }
        public DateTime createddate { get; set; }
        public DateTime? modifieddate { get; set; }
    }

    public class GLNInformationVM_Create
    {
        [Required]
        [StringLength(50)]
        public string registrationid { get; set; }
        [Required]
        [StringLength(50)]
        public string gln { get; set; }
        [StringLength(50)]
        public string companyprefix { get; set; }
    }
}
