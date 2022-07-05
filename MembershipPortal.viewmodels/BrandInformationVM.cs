using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class BrandInformationVM
    {
        public int id { get; set; }
        public string brandname { get; set; }
        public string registrationid { get; set; }
        public DateTime datecreated { get; set; }
        public DateTime datemodified { get; set; }
    }

    public class BrandInformationVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string brandname { get; set; }
        [Required]
        [StringLength(100)]
        public string registrationid { get; set; }
    }
}
