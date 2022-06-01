using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class ITF14Fee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string description { get; set; }
        public double applicationformprice { get; set; }
        public double registrationfee { get; set; }
        public double price { get; set; }
        public int numberofitf14 { get; set; }
        public double additionalitf14fee { get; set; }

        public ICollection<ITF14Request> ITF14Request_Fee { get; set; }
    }
}
