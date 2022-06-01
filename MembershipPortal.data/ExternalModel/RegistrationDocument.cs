using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationBackend.data.Models
{
    public class RegistrationDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public int company_id { get; set; }
        [Required]
        [StringLength(100)]
        public string registrationid { get; set; }
        [StringLength(200)]
        public string scannedtc1url { get; set; }
        [StringLength(200)]
        public string utilitybillurl { get; set; }
        [StringLength(200)]
        public string caccerturl { get; set; }
        [StringLength(200)]
        public string popaymenturl { get; set; }
        [StringLength(200)]
        public string nasum { get; set; }

        public DateTime dateuploaded { get; set; }

        public DateTime createdon { get; set; }

        public DateTime modifiedon { get; set; }

        [ForeignKey(nameof(company_id))]
        public Company Companies { get; set; }
    }
}
