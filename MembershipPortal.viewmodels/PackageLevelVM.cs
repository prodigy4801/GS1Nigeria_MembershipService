using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class PackageLevelVM
    {
        public int id { get; set; }
        public string level { get; set; }
        public DateTime createddate { get; set; }
        public DateTime? modifieddate { get; set; }
    }

    public class PackageLevelVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string level { get; set; }
    }
}
