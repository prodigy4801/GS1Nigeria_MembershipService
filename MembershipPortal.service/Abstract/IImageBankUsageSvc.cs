using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IImageBankUsageSvc : IService<ImageBankUsage>
    {
        Task<GenericResponse<ImageBankUsage>> GetByRegID_Gtin(string gtin, string registrationid);
    }
}
