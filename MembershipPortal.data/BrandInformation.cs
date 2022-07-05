using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class BrandInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string brandname { get; set; }
        [Required]
        [StringLength(100)]
        public string registrationid { get; set; }
        public DateTime createddate { get; set; }
        public DateTime modifieddate { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
