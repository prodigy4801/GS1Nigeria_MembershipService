using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IGCPInformationSvc : IService<GCPInformation>
    {
        Task<GenericResponseList<GCPInformation>> GetListByRegistrationID(string regId);
        Task<GenericResponseList<GCPInformation>> GetActiveListByRegistrationID(string regId);
        Task<GenericResponseList<GCPInformation>> GetAll(int? skip, int? take);
        Task<GenericResponse<GCPInformation>> SaveGCPAdditionalRequest(string registrationid, int requestedGTIN);
    }
}
