using Microsoft.Extensions.DependencyInjection;
using MembershipPortal.service.Concrete;
using MembershipPortal.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipPortal.configurations
{
    public class ServiceConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IBrickCategorySvc, BrickCategorySvc>();
            services.AddScoped<IGLNInformationSvc, GLNInformationSvc>();
            services.AddScoped<IGTINInformationSvc, GTINInformationSvc>();
            services.AddScoped<IITFInformationSvc, ITFInformationSvc>();
            services.AddScoped<INetContentSvc, NetContentSvc>();
            services.AddScoped<IPackageLevelSvc, PackageLevelSvc>();
            services.AddScoped<IPackagingTypeSvc, PackagingTypeSvc>();
            services.AddScoped<IProductSvc, ProductSvc>();
            services.AddScoped<ITargetMarketSvc, TargetMarketSvc>();
        }
    }
}
