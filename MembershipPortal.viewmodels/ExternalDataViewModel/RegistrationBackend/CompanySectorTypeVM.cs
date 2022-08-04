using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class CompanySectorTypeVM
    {
        public int id { get; set; }
        public string sectortype { get; set; }
    }

    public class CompanySectorTypeVM_CRU
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string sectortype { get; set; }
    }
}
