using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class ITFInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string registrationid { get; set; }
        [Required]
        [StringLength(50)]
        public string itf14 { get; set; }
        [StringLength(50)]
        public string companyprefix { get; set; }
    }
}
