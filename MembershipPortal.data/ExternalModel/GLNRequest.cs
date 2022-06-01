using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class GLNRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string registrationid { get; set; }
        [Required]
        public int company_id { get; set; }
        [Required]
        public int glnfee_id { get; set; }
        public int glncount { get; set; }
        public DateTime issuancedate { get; set; }
        public Boolean isemailsent { get; set; }
        public int glntype_id { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        [StringLength(500)]
        public string address { get; set; }
        public string department { get; set; }
        public string company_prefix { get; set; }
        public Boolean isapproved { get; set; }
        public string dateassigned { get; set; }
        public DateTime createdon { get; set; }
        public DateTime updatedon { get; set; }

        [ForeignKey(nameof(company_id))]
        public Company Companies { get; set; }

        [ForeignKey(nameof(glnfee_id))]
        public GLNFee GLNFee { get; set; }

        [ForeignKey(nameof(glntype_id))]
        public GLNType GLNType { get; set; }
    }
}
