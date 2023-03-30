using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IBrandInformationSvc : IService<BrandInformation>
    {
        Task<GenericResponseList<BrandInformation>> GetAll(int? skip, int? take);
        Task<GenericResponseList<BrandInformation>> GetAllActive(int? skip, int? take);
        Task<GenericResponse<BrandInformation>> GetByBrandName(string brandname);
        Task<GenericResponseList<BrandInformation>> GetByRegistrationID(string regId);
        Task<GenericResponse<bool>> IsExist(BrandInformation profile);
        //Task<bool> RecordExist(BrandInformation record);
    }
}
