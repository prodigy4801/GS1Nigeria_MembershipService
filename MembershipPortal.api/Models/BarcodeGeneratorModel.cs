using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GS1NGBarcodeLib;

namespace MembershipPortal.api.Models
{
    public class BarcodeGeneratorModel
    {
        public string gtin { get; set; }
        public BarcodeUtil.BarcodeFormat format { get; set; }
    }

    public class BarcodeResponseModel
    {
        public string MainImageLink { get; set; }
        public string DisplayImageLink { get; set; }
    }
}
