using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class GTINRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public int company_id { get; set; }
        [Required]
        public string registrationid { get; set; }
        [Required]
        public int gtinfee_id { get; set; }
        public int gtincount { get; set; }
        public double totalcost { get; set; }
        public DateTime dateofrequest { get; set; }
        public Boolean isapproved { get; set; }
        [StringLength(100)]
        public string approvedby { get; set; }
        public Boolean isgcpassigned { get; set; }
        public int imagerequest_id { get; set; }
        public DateTime createdon { get; set; }
        public DateTime updatedon { get; set; }

        [ForeignKey(nameof(company_id))]
        public Company Companies { get; set; }
        [ForeignKey(nameof(gtinfee_id))]
        public GTINFee GTINFee { get; set; }
    }
}
