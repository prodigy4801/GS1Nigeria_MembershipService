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
        ICompanyRepo CompanyRP { get; }
        IExternalUnifiedModelRepo ExternalUnifiedModelRP { get; }
        IGCPInformationRepo GCPInformationRP { get; }
        IGLNInformationRepo GLNInformationRP { get; }
        IGTINFeeRepo GTINFeeRP { get; }
        IGTINInformationRepo GTINInformationRP { get; }
        IGTINRequestRepo GTINRequestRP { get; }
        IImageBankRepo ImageBankRP { get; }
        IImageBankUsageRepo ImageBankUsageRP { get; }
        IImageRequestRepo ImageRequestRP { get; }
        IITFInformationRepo ITFInformationRP { get; }
        INetContentRepo NetContentRP { get; }
        IPackageLevelRepo PackageLevelRP { get; }
        IPackagingTypeRepo PackagingTypeRP { get; }
        IPharmaceuticalInformationRepo PharmaceuticalInformationRP { get; }
        IProductRepo ProductRP { get; }
        IProductTargetMarketRepo ProductTargetMarketRP { get; }
        ITargetMarketRepo TargetMarketRP { get; }
        IUserRepo UserRP { get; }

        Task<int> Complete();
    }
}
