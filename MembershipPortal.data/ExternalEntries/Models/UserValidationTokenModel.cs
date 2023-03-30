using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.data.ExternalEntries.Models
{
    public class UserValidationTokenModel
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string subvalidationtoken { get; set; }
        public bool isactive { get; set; } = true;
        public string ipaddress { get; set; }
        public DateTime expirationDate { get; set; }
        public DateTimeOffset datecreated { get; set; }
        public DateTimeOffset datemodified { get; set; }

        public UserModel User { get; set; }
    }
}
