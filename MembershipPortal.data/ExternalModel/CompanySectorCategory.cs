using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class CompanySectorCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string sectorcategory { get; set; }
        [Required]
        [StringLength(20)]
        public string sectorcode { get; set; }

        public ICollection<Company> Company_SectorCategory { get; set; }
    }
}
