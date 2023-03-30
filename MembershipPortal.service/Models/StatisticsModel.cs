using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service.Models
{
    public class GCPRequestCompact
    {
        public int ID { get; set; }
        public DateTime DateOfIssuance { get; set; }
        public int NumberOfGtins { get; set; }
        public string RegistrationID { get; set; }
    }
    public class RenewalAccumulationModel
    {
        public int YearCount { get; set; }
        public string RenewalYear { get; set; }
        public int GtinCount { get; set; }
        public decimal Amount { get; set; }
        public int AccumulatedGtin { get; set; }
        public double AccumulatedAmount { get; set; }
    }

    public class CompanyRenewalAccumulationModel
    {
        public string FirstInsuanceDate { get; set; }
        public int FirstIssuedGtin { get; set; }
        public string CompanyName { get; set; }
        public List<RenewalAccumulationModel> AccumulatedInfo { get; set; }
    }
}
