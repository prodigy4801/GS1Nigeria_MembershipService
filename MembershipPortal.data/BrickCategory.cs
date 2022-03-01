using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class BrickCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        //[Required]
        [StringLength(100)]
        public string brick_id { get; set; }
        [Required]
<<<<<<< HEAD
        public int brick_id { get; set; }
        public DateTime createddate { get; set; }
        public DateTime modifieddate { get; set; } 
        public string brick { get; set; }
        public List<Product> Products { get; set; }

       
=======
        [StringLength(100)]
        public string brick { get; set; }
        public List<Product> Products { get; set; }

        //public DateTime createddate { get; set; }
        //public DateTime? modifieddate { get; set; }
>>>>>>> c3bfcb876cb8446ba1552801bb5433187e2c3bfa
    }
}
