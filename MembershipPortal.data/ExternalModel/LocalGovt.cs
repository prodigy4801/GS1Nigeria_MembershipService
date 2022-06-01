using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class LocalGovt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string name { get; set; }
        [Required]
        public int state_id { get; set; }

        [ForeignKey(nameof(state_id))]
        public State States { get; set; }
        public ICollection<Company> Company_LocalGovt { get; set; }
    }
}
