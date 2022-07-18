using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core.Repository;

namespace MembershipPortal.core
{
    public interface IUnitOfWork : IDisposable
    {
        IBrandInformationRepo BrandInformationRP { get; }
        IBrickCategoryRepo BrickCategoryRP { get; }
        IExternalUnifiedModelRepo ExternalUnifiedModelRP { get; }
        IGLNInformationRepo GLNInformationRP { get; }
        IGTINInformationRepo GTINInformationRP { get; }
        IITFInformationRepo ITFInformationRP { get; }
        INetContentRepo NetContentRP { get; }
        IPackageLevelRepo PackageLevelRP { get; }
        IPackagingTypeRepo PackagingTypeRP { get; }
        IProductRepo ProductRP { get; }
        ITargetMarketRepo TargetMarketRP { get; }

        Task<int> Complete();
    }
}
