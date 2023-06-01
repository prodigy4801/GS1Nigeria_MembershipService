using Microsoft.Extensions.DependencyInjection;
using MembershipPortal.core;
using MembershipPortal.core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.configurations
{
    public class RepositoryConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IBrandInformationRepo, BrandInformationRepo>();
            services.AddScoped<IBrickCategoryRepo, BrickCategoryRepo>();
            services.AddScoped<ICompanyRepo, CompanyRepo>();
            services.AddScoped<IExternalUnifiedModelRepo, ExternalUnifiedModelRepo>();
            services.AddScoped<IGCPInformationRepo, GCPInformationRepo>();
            services.AddScoped<IGLNInformationRepo, GLNInformationRepo>();
            services.AddScoped<IGTINFeeRepo, GTINFeeRepo>();
            services.AddScoped<IGTINInformationRepo, GTINInformationRepo>();
            services.AddScoped<IGTINRequestRepo, GTINRequestRepo>();
            services.AddScoped<IImageBankRepo, ImageBankRepo>();
            services.AddScoped<IImageBankUsageRepo, ImageBankUsageRepo>();
            services.AddScoped<IImageRequestRepo, ImageRequestRepo>();
            services.AddScoped<IITFInformationRepo, ITFInformationRepo>();
            services.AddScoped<INetContentRepo, NetContentRepo>();
            services.AddScoped<IPackageLevelRepo, PackageLevelRepo>();
            services.AddScoped<IPackagingTypeRepo, PackagingTypeRepo>();
            services.AddScoped<IPharmaceuticalInformationRepo, PharmaceuticalInformationRepo>();
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<IProductTargetMarketRepo, ProductTargetMarketRepo>();
            services.AddScoped<ITargetMarketRepo, TargetMarketRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
        }
    }
}
