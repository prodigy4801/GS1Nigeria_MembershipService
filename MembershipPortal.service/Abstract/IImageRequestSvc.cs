using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IImageRequestSvc : IService<ImageRequest>
    {
        Task<GenericResponseList<ImageRequest>> GetListByRegistrationID(string registrationid);
        Task<GenericResponse<ImageRequest>> SaveImage(string registrationid, int imageCount, string imageType);
    }
}
