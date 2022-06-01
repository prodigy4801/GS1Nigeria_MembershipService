using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [ForeignKey(nameof(Companies))]
        public int company_id { get; set; }
        [Required]
        [StringLength(200)]
        public string email { get; set; }
        [Required]
        [StringLength(200)]
        public string password { get; set; }
        [Required]
        [StringLength(100)]
        public string registrationid { get; set; }
        public int role_id { get; set; }
        public Boolean active { get; set; }
        // [Required]
        [StringLength(100)]
        public string firstname { get; set; }
        // [Required]
        [StringLength(100)]
        public string lastname { get; set; }
        public DateTime createdon { get; set; }
        public DateTime updatedon { get; set; }

        [ForeignKey(nameof(company_id))]
        public Company Companies { get; set; }

        [ForeignKey(nameof(role_id))]
        public Role Roles { get; set; }
    }
}
