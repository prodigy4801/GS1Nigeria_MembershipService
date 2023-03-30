using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class ImageRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(10)]
        public string imagetype { get; set; }
        [Required]
        [StringLength(20)]
        public string registrationid { get; set; }
        public int imagecount { get; set; }
        public Boolean isapproved { get; set; }

        [StringLength(50)]
        public string approvedby { get; set; }
        public DateTime requestedate { get; set; }
        public DateTime createdon { get; set; }
        public DateTime updatedon { get; set; }
    }
}
