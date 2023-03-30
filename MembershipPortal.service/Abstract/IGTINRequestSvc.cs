using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IGTINRequestSvc : IService<GTINRequest>
    {
        Task<GenericResponseList<GTINRequest>> GetAll(int skip, int take);
        Task<GenericResponseList<GTINRequest>> GetListByRegistrationID(string regid);
        Task<GenericResponse<GTINRequest>> Save(GTINRequest profile, int? imageCount);
        Task<GenericResponse<bool>> IsExist(string regid);
    }
}
