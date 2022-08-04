using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class GLNTypeVM
    {
        public int id { get; set; }
        public string glntype { get; set; }
        public string description { get; set; }
    }

    public class GLNTypeVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string glntype { get; set; }
        public string description { get; set; }
    }
}
