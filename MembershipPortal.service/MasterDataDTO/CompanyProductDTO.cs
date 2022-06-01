using System.Collections.Generic;

namespace MembershipPortal.service.MasterDataDTO
{
    public class CompanyProductDTO{
        public CompanyProductDTO(){
            Products = new List<ProductDTO>();
            Company = new CompanyDTO();
        }
        public CompanyDTO Company { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}