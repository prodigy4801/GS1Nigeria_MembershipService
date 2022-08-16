using MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class LoginVM
    {
        public string email { get; set; }
        public string password { get; set; }
    }

    public class AuthenticatedPayload
    {
        public int id { get; set; }
        public int company_id { get; set; }
        public string email { get; set; }
        public int role_id { get; set; }
        public string registrationid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public bool active { get; set; }
        public DateTimeOffset createdon { get; set; }
        public DateTimeOffset modifiedon { get; set; }

        public CompanyVM Companies { get; set; }
        public RoleVM Roles { get; set; }
        //public List<GLNRequestVM> User_GLNRequest { get; set; }
    }

    public class RegistrationVM_CRU
    {
        public int id { get; set; }
        public int company_id { get; set; }
        [Required]
        [StringLength(200)]
        public string email { get; set; }
        public int role_id { get; set; }
        [StringLength(100)]
        public string firstname { get; set; }
        [StringLength(100)]
        public string lastname { get; set; }
        public bool active { get; set; }
        [Required]
        [StringLength(200)]
        public string password { get; set; }
    }
}
