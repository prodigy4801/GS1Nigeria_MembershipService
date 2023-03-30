using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class GTINFee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public double RenewalFee { get; set; }

        public double Price { get; set; }

        public int NumberOfGtins { get; set; }

        public double AdditionalFee { get; set; }
    }
}
