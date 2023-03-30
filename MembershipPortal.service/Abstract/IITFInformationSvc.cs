using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IITFInformationSvc : IService<ITFInformation>
    {
        Task<GenericResponseList<ITFInformation>> GetAll(int? skip, int? take);
        Task<GenericResponse<ITFInformation>> GetByRegistrationID(string regId);
    }
}
