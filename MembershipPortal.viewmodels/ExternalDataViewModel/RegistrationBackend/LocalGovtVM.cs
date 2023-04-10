using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class LocalGovtVM
    {
        //public int id { get; set; }
        public string name { get; set; }
        public int state_id { get; set; }
        public StateVM States { get; set; }
    }

    public class LocalGovtVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string name { get; set; }
        [Required]
        public int state_id { get; set; }
    }
}
