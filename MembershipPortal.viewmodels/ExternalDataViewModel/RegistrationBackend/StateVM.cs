using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class StateVM
    {
        public int id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public CountryVM Country { get; set; }
    }

    public class StateVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string name { get; set; }
        public int country_id { get; set; }
    }
}
