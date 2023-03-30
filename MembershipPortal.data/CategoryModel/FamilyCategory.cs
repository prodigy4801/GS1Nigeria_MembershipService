using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class FamilyCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public int FamilyCode { get; set; }
        [Required]
        public int SegmentCode { get; set; }
        [Required]
        [StringLength(500)]
        public string FamilyTitle { get; set; }
        public string FamilyDefinition { get; set; }

        [ForeignKey(nameof(SegmentCode))]
        public SegmentCategory SegmentCategory { get; set; }
    }
}
