using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data
{
    public class ContactInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int company_id { get; set; }
        // [Required]
        [StringLength(200)]
        public string billingname { get; set; }
        // [Required]
        [StringLength(200)]
        public string billingemail { get; set; }
        [StringLength(200)]
        public string billingdesignation { get; set; }
        // [Required]
        [StringLength(200)]
        public string billingphonenumber { get; set; }
        // [Required]
        [StringLength(200)]
        public string ceoemail { get; set; }
        // [Required]
        [StringLength(200)]
        public string ceoname { get; set; }
        // [Required]
        [StringLength(200)]
        public string ceodesignation { get; set; }
        // [Required]
        [StringLength(200)]
        public string ceophonenumber { get; set; }
        // [Required]
        [StringLength(200)]
        public string contactperson { get; set; }
        // [Required]
        [StringLength(200)]
        public string contactemail { get; set; }
        // [Required]
        [StringLength(200)]
        public string contactphonenumber { get; set; }
        // [Required]
        [StringLength(200)]
        public string salename { get; set; }
        // [Required]
        [StringLength(200)]
        public string saleemail { get; set; }
        // [Required]
        [StringLength(200)]
        public string salephonenumber { get; set; }
        // [Required]
        [StringLength(200)]
        public string salesdesignation { get; set; }
        [StringLength(300)]
        public string reasonforapplying { get; set; }
        public DateTime createdon { get; set; }
        public DateTime modifiedon { get; set; }
        public int? heardaboutus_id { get; set; }
        [StringLength(20)]
        public string registrationId { get; set; }
        [ForeignKey("heardaboutus_id")]
        public HeardAboutUs HeardAboutUs { get; set; }
    }
}
