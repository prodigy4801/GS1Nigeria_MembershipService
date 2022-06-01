using System.Collections.Generic;
using System.Threading.Tasks;
using MembershipPortal.service.MasterDataDTO;
using MembershipPortal.viewmodels;

namespace MembershipPortal.service
{
    public interface IDataService
    {
   
        public Task<ReturnSignature<ProductDTO>> GetProductByGtin(ProductByGtinPayload payload);
        public Task<ReturnSignature<List<ProductDTO>>> GetProductByEmail(ProductByEmailPayload payload);
        public Task<ReturnSignature<CompanyProductDTO>> OnboardCompanyByEmail(OnboardByEmailPayload payload);
        Task<ReturnSignature<PackedDTOForEPCIS>> GetDataForPrep(List<string> gtins);
        Task<ReturnSignature<List<LocationInformation>>> GetLocationInformation(string email);
    }
}