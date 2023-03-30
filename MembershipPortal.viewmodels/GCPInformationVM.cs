using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels
{
    public class GCPInformationVM
    {
        public int ID { get; set; }
        public string RegistrationID { get; set; }
        public string CompanyPrefix { get; set; }
        public string AssignBy { get; set; }
        public int GtinCount { get; set; }
        public int MaxGtin { get; set; }
        public bool Active { get; set; }
        public bool IsEmailSent { get; set; }
        public DateTime DateOfIssuance { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
    }

    public class GCPInformationVM_Create
    {
        [Required]
        [StringLength(20)]
        public string RegistrationID { get; set; }
        [Required]
        [StringLength(25)]
        public string CompanyPrefix { get; set; }
        [Required]
        [StringLength(200)]
        public string AssignBy { get; set; }
        public int GtinCount { get; set; }
        public int MaxGtin { get; set; }
    }

    public class GCPInformationVM_Update
    {
        [Required]
        [StringLength(200)]
        public int ID { get; set; }
        public int GtinCount { get; set; }
        public int MaxGtin { get; set; }
        public bool Active { get; set; }
        public bool IsEmailSent { get; set; }
        public DateTime DateOfIssuance { get; set; }
    }

    public class GCPInformationVM_ChangeStatus
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string RegistrationID { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}
