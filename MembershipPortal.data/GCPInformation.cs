using System;

namespace MembershipPortal.data
{
    public class GCPInformation{
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
}