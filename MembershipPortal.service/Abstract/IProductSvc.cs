using MembershipPortal.data;
using MembershipPortal.service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IProductSvc : IService<Product>
    {
        Task<GenericResponseList<Product>> GetByRegistrationID(string regId);
        Task<GenericResponse<Product>> GetByProdRegID(int prodId, string regId);
        Task<GenericResponse<bool>> ProductExist(string gtin, string brandName);
        Task<GenericResponse<Product>> SaveProductWithImage(Product profile, ImageUploadModel uploads);
        Task<GenericServiceResponseList<Product>> SaveProductListWithoutGTIN(IEnumerable<Product> products, string registrationid);
        Task<GenericResponse<Product>> SaveUpdateWithImage(Product profile, List<string> targetmktListIDs, ImageUploadModel imageFile, PharmaceuticalInformation pharmaProduct);
        Task<GenericResponseList<Product>> SaveProductList(IEnumerable<Product> products, string registrationID);
        Task<GenericResponseList<Product>> GetAll(int? skip, int? take);
    }
}
