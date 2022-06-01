using System.Collections.Generic;

namespace MembershipPortal.service.MasterDataDTO
{
    public class ProductByGtinPayload{
        public ProductByGtinPayload(){
            MandatoryAttributes = new List<string>();
        }
        public string Gtin { get; set; }
        public List<string> MandatoryAttributes { get; set; }
    }

    public class ProductByEmailPayload{
        public ProductByEmailPayload(){
            MandatoryAttributes = new List<string>();
        }
        public string Email { get; set; }
        public List<string> MandatoryAttributes { get; set; }
    }
    public class OnboardByEmailPayload{
        public OnboardByEmailPayload(){
            MandatoryAttributes = new List<string>();
        }
        public string Email { get; set; }
        public List<string> MandatoryAttributes { get; set; }
    }
}