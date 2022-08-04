using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class CompanySectorCategoryVM
    {
        public int id { get; set; }
        public string sectorcategory { get; set; }
    }
    public class CompanySectorCategoryVM_CRU
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string sectorcategory { get; set; }
    }
}
