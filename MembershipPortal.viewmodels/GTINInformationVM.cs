using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class GTINInformationVM
    {
        public int id { get; set; }
        public string registrationid { get; set; }
        public string gtin { get; set; }
        public string companyprefix { get; set; }
        public string productcode { get; set; }
        public int checksum { get; set; }
        public DateTime createddate { get; set; }
        public DateTime? modifieddate { get; set; }
    }

    public class GTINInformationVM_Create
    {
        [Required]
        [StringLength(50)]
        public string registrationid { get; set; }
        [Required]
        [StringLength(50)]
        public string gtin { get; set; }
        [StringLength(50)]
        public string companyprefix { get; set; }
        [StringLength(50)]
        public string productcode { get; set; }
        public int checksum { get; set; }
    }
}
