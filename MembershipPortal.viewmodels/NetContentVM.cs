using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class NetContentVM
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime createddate { get; set; }
        public DateTime? modifieddate { get; set; }
    }

    public class NetContentVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string code { get; set; }
        [Required]
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(200)]
        public string description { get; set; }
    }
}
