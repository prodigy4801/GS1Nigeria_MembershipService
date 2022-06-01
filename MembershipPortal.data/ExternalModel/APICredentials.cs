using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationBackend.data.Models
{
    public class APICredentials
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(200)]
        public string full_name { get; set; }
        //[Required]
        [StringLength(200)]
        public string email { get; set; }
        [Required]
        [StringLength(200)]
        public string username { get; set; }
        [Required]
        [StringLength(300)]
        public string password { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
