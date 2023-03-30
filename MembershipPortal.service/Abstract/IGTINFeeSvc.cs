using MembershipPortal.data;
using MembershipPortal.data.ExternalEntries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.service
{
    public interface IGTINFeeSvc : IService<GTINFee>
    {
        Task<GenericResponseList<GTINFee>> GetAll(int skip, int take);
        Task<GenericResponse<GTINFee>> GetByNumberOfGTIN(int numberofgtin);
    }
}
