using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class CountryVM
    {
        //public int id { get; set; }
        public string name { get; set; }
    }

    public class CountryVM_CRU
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string name { get; set; }
    }
}
