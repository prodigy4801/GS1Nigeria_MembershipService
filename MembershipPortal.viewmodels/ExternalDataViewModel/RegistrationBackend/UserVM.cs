using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class UserVM
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string registrationid { get; set; }
        public int role_id { get; set; }
        public Boolean active { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime createdon { get; set; }
        public DateTime updatedon { get; set; }
        public CompanyVM Companies { get; set; }
    }

    public class UserVM_CRU
    {
        public int id { get; set; }
        [Required]
        public int company_id { get; set; }
        [Required]
        [StringLength(200)]
        public string email { get; set; }
        [Required]
        [StringLength(200)]
        public string password { get; set; }
        [Required]
        [StringLength(100)]
        public string registrationid { get; set; }
        public int role_id { get; set; }
        public Boolean active { get; set; }
        [Required]
        [StringLength(100)]
        public string firstname { get; set; }
        [Required]
        [StringLength(100)]
        public string lastname { get; set; }
    }
}
