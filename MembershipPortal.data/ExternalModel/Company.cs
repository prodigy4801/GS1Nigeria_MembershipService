using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationBackend.data.Models
{

   
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(300)]
        public string companyname { get; set; }
        // [Required]
        [StringLength(200)]
        public string email { get; set; }
        // [Required]
        [StringLength(20)]
        public string phonenumber { get; set; }
        public int country_id { get; set; }
        public int? state_id { get; set; }
        public int? localgovt_id { get; set; }
        [Required]
        [StringLength(20)]
        public string registrationid { get; set; }
       
        [StringLength(500)]
        public string companyaddress { get; set; }
        [StringLength(500)]
        public string factoryaddress { get; set; }
        public DateTime? registrationdate { get; set; }
        public DateTime? dateofincorporation { get; set; }
        // [Required]
        [StringLength(20)]
        public string cacnumber { get; set; }
        
        [StringLength(500)]
        public string websiteaddress { get; set; }
        public Boolean isregistrationcompleted { get; set; }
        [StringLength(200)]
        public string facebookaccount { get; set; }
        [StringLength(200)]
        public string twitteraccount { get; set; }
        [StringLength(200)]
        public string instagramaccount { get; set; }
        // public int contactinformation_id { get; set; }
        public int numberofstaff { get; set; }
        public int? sectortype_id { get; set; }
        public int? sectorcategory_id { get; set; }
        public Boolean approvalstatus { get; set; }
        public DateTime createdon { get; set; }
        public DateTime modifiedon { get; set; }

        [ForeignKey(nameof(country_id))]
        public Country Countries { get; set; }
        //[ForeignKey(nameof(state_id))]
        //public State States { get; set; }
        [ForeignKey(nameof(localgovt_id))]
        public LocalGovt LocalGovts { get; set; }

        [ForeignKey(nameof(sectorcategory_id))]
        public CompanySectorCategory CompanySectorCategories { get; set; }

        [ForeignKey(nameof(sectortype_id))]
        public CompanySectorType CompanySectorTypes { get; set; }
        //[ForeignKey(nameof(contactinformation_id))]
        public ContactInformation ContactInformation { get; set; }
        public ICollection<User> User_Company { get; set; }
        public ICollection<GLNRequest> GLNRequest_Company { get; set; }
        public ICollection<GTINRequest> GTINRequests_Company { get; set; }
        public ICollection<ITF14Request> ITF14Request_Company { get; set; }
        public ICollection<RegistrationDocument> RegDocument_Company { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime DateOfApproval { get; set; }
       
        
    }
}
