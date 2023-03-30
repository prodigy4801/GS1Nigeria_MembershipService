using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipPortal.api.Models
{
    public class DashboardVM
    {
        public long TotalGtinsRequested { get; set; } = 0;
        public long UsedGtins { get; set; } = 0;
        public long RemainingGtins { get; set; } = 0;
        public int TotalImagesRequested { get; set; } = 0;
        public int UsedImages { get; set; } = 0;
        public int RemainingImages { get; set; } = 0;
        public bool PendingGCPStatus { get; set; } = false;
        public bool PendingImageRequest { get; set; } = false;
        public string NextPaymentDate { get; set; } = string.Empty;
        public decimal NextRenewalAmount { get; set; } = 0;

    }
}
