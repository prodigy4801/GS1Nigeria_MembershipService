using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class CompanyVM : BaseEntityVM
    {
        public string companyname { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        public int? country_id { get; set; }
        public int? state_id { get; set; }
        public int? localgovt_id { get; set; }
        public string registrationid { get; set; }
        public string companyaddress { get; set; }
        public string factoryaddress { get; set; }
        public DateTime? registrationdate { get; set; }
        public DateTime? dateofincorporation { get; set; }
        public string cacnumber { get; set; }
        public string websiteaddress { get; set; }
        public Boolean isregistrationcompleted { get; set; }
        public string facebookaccount { get; set; }
        public string twitteraccount { get; set; }
        public string instagramaccount { get; set; }
        public int? contactinformation_id { get; set; }
        public int numberofstaff { get; set; }
        public int? sectortype_id { get; set; }
        public int? sectorcategory_id { get; set; }
        public Boolean approvalstatus { get; set; }

        public LocalGovtVM LocalGovt { get; set; }

        public CompanySectorTypeVM CompanySectorTypes { get; set; }
        public ContactInformationVM ContactInformation { get; set; }
        public CompanySectorCategoryVM CompanySectorCategories { get; set; }
    }

    public class CompanyVM_auth
    {
        public string companyname { get; set; }
        public string email { get; set; }
        public string phonenumber { get; set; }
        //public int? country_id { get; set; }
        //public int? state_id { get; set; }
        //public int? localgovt_id { get; set; }
        public string registrationid { get; set; }
        //public string companyaddress { get; set; }
        //public string factoryaddress { get; set; }
        public DateTime? registrationdate { get; set; }
        //public DateTime? dateofincorporation { get; set; }
        //public string cacnumber { get; set; }
        //public string websiteaddress { get; set; }
        public Boolean isregistrationcompleted { get; set; }
        //public string facebookaccount { get; set; }
        //public string twitteraccount { get; set; }
        //public string instagramaccount { get; set; }
        //public int? contactinformation_id { get; set; }
        //public int numberofstaff { get; set; }
        //public int? sectortype_id { get; set; }
        //public int? sectorcategory_id { get; set; }
        public Boolean approvalstatus { get; set; }

        public CountryVM Countries { get; set; }

        public LocalGovtVM LocalGovts { get; set; }
    }

    public class CompanyVM_CRU
    {
        public int id { get; set; }
        [Required]
        [StringLength(300)]
        public string companyname { get; set; }
        [Required]
        [StringLength(200)]
        public string email { get; set; }
        public string phonenumber { get; set; }
        public int country_id { get; set; }
        public int state_id { get; set; }
        public int localgovt_id { get; set; }
        [StringLength(20)]
        public string registrationid { get; set; }
        [Required]
        [StringLength(500)]
        public string companyaddress { get; set; }
        [StringLength(500)]
        public string factoryaddress { get; set; }
        public DateTime registrationdate { get; set; }
        public DateTime dateofincorporation { get; set; }
        [Required]
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
        public int contactinformation_id { get; set; }
        public int numberofstaff { get; set; }
        public int sectortype_id { get; set; }
        public int sectorcategory_id { get; set; }
    }
}
