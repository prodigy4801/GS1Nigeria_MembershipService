using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class TargetMarketVM
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class TargetMarketVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string name { get; set; }
    }
}
