using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data.ExternalEntries.Models
{
    public class UserModel
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
        public CompanyModel Companies { get; set; }
        public RoleModel Roles { get; set; }
    }
}
