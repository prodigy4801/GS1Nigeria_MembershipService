using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class GLNFeeVM
    {
        public int id { get; set; }
        public string description { get; set; }
        public double applicationformprice { get; set; }
        public double registrationfee { get; set; }
        public double price { get; set; }
        public int numberofgln { get; set; }
        public double additionalglnfee { get; set; }
    }

    public class GLNFeeVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string description { get; set; }
        public double applicationformprice { get; set; }
        public double registrationfee { get; set; }
        public double price { get; set; }
        public int numberofgln { get; set; }
        public double additionalglnfee { get; set; }
    }
}
