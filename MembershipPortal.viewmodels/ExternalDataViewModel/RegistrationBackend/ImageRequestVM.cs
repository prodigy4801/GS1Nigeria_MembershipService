using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class ImageRequestVM
    {
        public int id { get; set; }
        public string imagetype { get; set; }
        public string registrationid { get; set; }
        public int imagecount { get; set; }
        public Boolean isapproved { get; set; }
        public string approvedby { get; set; }
        public DateTime requestedate { get; set; }
    }

    public class ImageRequestVM_request
    {
        [Required]
        public string registrationid { get; set; }
        [Required]
        public int imagecount { get; set; }
    }
}
