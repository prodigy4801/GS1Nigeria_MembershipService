using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IGLNInformationSvc : IService<GLNInformation>
    {
        Task<GenericResponseList<GLNInformation>> GetAll(int? skip, int? take);
        Task<GenericResponseList<GLNInformation>> GetByRegistrationID(string regId);
    }
}
