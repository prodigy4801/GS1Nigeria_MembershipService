using MembershipPortal.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.core.Repository
{
    public interface IExternalUnifiedModelRepo : IGenericRepository<ExternalUnifiedModel>
    {
        Task<bool> IsExists(ExternalUnifiedModel profile);
        Task<IEnumerable<ExternalUnifiedModel>> GetAllDependencies();
        Task<ExternalUnifiedModel> GetByIDDependencies(int id);
    }
}
