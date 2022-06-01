using System.Collections.Generic;

namespace MembershipPortal.viewmodels
{
    public class GtinPrefixDTO{
         public string CompanyEmail { get; set; }
        public string Gtin { get; set; }
        public string Prefix { get; set; }
    }

    public class PackedDTOForEPCIS{
        public List<string> AllPrefixes { get; set; }
        public List<GtinPrefixDTO> GtinPrefixDTO { get; set; }
    }
}