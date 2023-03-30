using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.viewmodels.ExternalDataViewModel.RegistrationBackend
{
    public class GTINFeeVM
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public double RenewalFee { get; set; }
        public double Price { get; set; }
        public int NumberOfGtins { get; set; }
        public double AdditionalFee { get; set; }
    }
}
