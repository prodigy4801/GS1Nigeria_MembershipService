using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class DeletedApplication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(500)]
        public string reason { get; set; }
        [Required]
        [StringLength(200)]
        public string email { get; set; }
        [StringLength(200)]
        public string phonenumber { get; set; }
        public DateTime registrationdate { get; set; }
        [StringLength(200)]
        public string companyname { get; set; }
        [StringLength(500)]
        public string address { get; set; }
        [StringLength(100)]
        public string deletedby { get; set; }
    }
}
