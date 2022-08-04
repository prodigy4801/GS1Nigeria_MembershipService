using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class HeardAboutUsVM
    {
        public int id { get; set; }
        public string method { get; set; }
    }

    public class HeardAboutUsVM_CRU
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string method { get; set; }
    }
}
