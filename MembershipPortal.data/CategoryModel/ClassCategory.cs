using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class ClassCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int ClassCode { get; set; }
        [Required]
        public int FamilyCode { get; set; }
        [Required]
        [StringLength(500)]
        public string ClassTitle { get; set; }
        public string ClassDefinition { get; set; }

        [ForeignKey(nameof(FamilyCode))]
        public FamilyCategory FamilyCategory { get; set; }
    }
}
