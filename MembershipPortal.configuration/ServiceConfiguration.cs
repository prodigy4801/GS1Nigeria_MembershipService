using Microsoft.Extensions.DependencyInjection;
using MembershipPortal.service.Concrete;
using MembershipPortal.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.service.Concrete.ExternalEntries;

namespace MembershipPortal.configurations
{
    public class ServiceConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IUserSvc, UserSvc>();
            services.AddScoped<ICompanySvc, CompanySvc>();
            services.AddScoped<IGTINRequestSvc, GTINRequestSvc>();
            services.AddScoped<IGTINFeeSvc, GTINFeeSvc>();
            services.AddScoped<IImageRequestSvc, ImageRequestSvc>();
            services.AddScoped<IUserValidationTokenSvc, UserValidationTokenSvc>();

            services.AddScoped<IAuthenticationSvc, AuthenticationSvc>();
            services.AddScoped<IBrandInformationSvc, BrandInformationSvc>();
            services.AddScoped<IBrickCategorySvc, BrickCategorySvc>();
            services.AddScoped<IExternalUnifiedModelSvc, ExternalUnifiedModelSvc>();
            services.AddScoped<IGCPInformationSvc, GCPInformationSvc>();
            services.AddScoped<IGLNInformationSvc, GLNInformationSvc>();
            services.AddScoped<IGTINInformationSvc, GTINInformationSvc>();
            services.AddScoped<IGTINRequestSvc, GTINRequestSvc>();
            services.AddScoped<IImageBankSvc, ImageBankSvc>();
            services.AddScoped<IITFInformationSvc, ITFInformationSvc>();
            services.AddScoped<INetContentSvc, NetContentSvc>();
            services.AddScoped<IPackageLevelSvc, PackageLevelSvc>();
            services.AddScoped<IPackagingTypeSvc, PackagingTypeSvc>();
            services.AddScoped<IPharmaceuticalInformationSvc, PharmaceuticalInformationSvc>();
            services.AddScoped<IProductSvc, ProductSvc>();
            services.AddScoped<IProductTargetMarketSvc, ProductTargetMarketSvc>();
            services.AddScoped<ITargetMarketSvc, TargetMarketSvc>();

            services.AddScoped<IStatisticsService, StatisticsService>();
        }
    }
}
