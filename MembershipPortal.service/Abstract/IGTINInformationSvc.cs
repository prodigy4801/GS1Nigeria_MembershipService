using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IGTINInformationSvc : IService<GTINInformation>
    {
        Task<GenericResponseList<GTINInformation>> GetAll(int? skip, int? take);
        Task<GenericResponse<GTINInformation>> GetByRegistrationID(string regId);
        Task<GenericResponseList<GTINInformation>> GetListByRegistrationID(string regId);
        Task<GenericResponse<long>> CountListedGtinByRegID(string regId);
    }
}
