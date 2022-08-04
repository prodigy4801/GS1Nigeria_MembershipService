using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class ContactInformationVM
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public string billingname { get; set; }
        public string billingemail { get; set; }
        public string billingdesignation { get; set; }
        public string billingphonenumber { get; set; }
        public string ceoemail { get; set; }
        public string ceoname { get; set; }
        public string ceodesignation { get; set; }
        public string ceophonenumber { get; set; }
        public string salename { get; set; }
        public string saleemail { get; set; }
        public string salephonenumber { get; set; }
        public string salesdesignation { get; set; }
        public string reasonforapplying { get; set; }
        public DateTime createdon { get; set; }
        public DateTime modifiedon { get; set; }
        public int heardaboutus_id { get; set; }
        public string registrationId { get; set; }
        public CompanyVM Companies { get; set; }
        public HeardAboutUsVM HeardAboutUs { get; set; }
    }

    public class ContactInformationVM_CRU
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int company_id { get; set; }
        [Required]
        [StringLength(200)]
        public string billingname { get; set; }
        [Required]
        [StringLength(200)]
        public string billingemail { get; set; }
        [StringLength(200)]
        public string billingdesignation { get; set; }
        [Required]
        [StringLength(200)]
        public string billingphonenumber { get; set; }
        [Required]
        [StringLength(200)]
        public string ceoemail { get; set; }
        [Required]
        [StringLength(200)]
        public string ceoname { get; set; }
        [Required]
        [StringLength(200)]
        public string ceodesignation { get; set; }
        [Required]
        [StringLength(200)]
        public string ceophonenumber { get; set; }
        [Required]
        [StringLength(200)]
        public string salename { get; set; }
        [Required]
        [StringLength(200)]
        public string saleemail { get; set; }
        [Required]
        [StringLength(200)]
        public string salephonenumber { get; set; }
        [Required]
        [StringLength(200)]
        public string salesdesignation { get; set; }
        [StringLength(300)]
        public string reasonforapplying { get; set; }
        public int heardaboutus_id { get; set; }
        [StringLength(20)]
        public string registrationId { get; set; }
    }
}
