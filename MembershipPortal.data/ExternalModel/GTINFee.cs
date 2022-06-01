using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class GTINFee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string description { get; set; }
        public double applicationformprice { get; set; }
        public double registrationfee { get; set; }
        public double renewalfee { get; set; }
        public double price { get; set; }
        public int numberofgtin { get; set; }
        public double additionalbarcodefee { get; set; }

        public ICollection<GTINRequest> GTINRequest_Fee { get; set; }
    }
}
