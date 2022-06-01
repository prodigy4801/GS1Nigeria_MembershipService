using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class ITF14Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string registrationid { get; set; }
        [Required]
        public int company_id { get; set; }
        public int itf14_count { get; set; }
        [Required]
        public int itf14fee_id { get; set; }
        public int imagerequest_id { get; set; }

        [ForeignKey(nameof(company_id))]
        public Company Companies { get; set; }

        [ForeignKey(nameof(itf14fee_id))]
        public ITF14Fee ITF14Fee { get; set; }
    }
}
