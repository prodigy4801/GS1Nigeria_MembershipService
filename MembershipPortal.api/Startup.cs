using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MembershipPortal.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MembershipPortal.configurations;
using MembershipPortal.service;
using MembershipPortal.service.Concrete;
using MembershipPortal.core;
using MembershipPortal.core.Repository;
using MembershipPortal.api.Models;
using MembershipPortal.api.Helpers.RegistrationAPIService;
using MembershipPortal.api.Helpers;
using MembershipPortal.api.Authorization;

namespace MembershipPortal.api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MembershipPortalConfig"),
                x => x.MigrationsHistoryTable("__opensourcemigrationhistory")));
            services.AddDbContext<RegistrationDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("RegistrationConfig"),
            x => x.MigrationsHistoryTable("__opensourcemigrationhistory")));
            services.AddControllers().AddNewtonsoftJson();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v2", new OpenApiInfo { Title = "MembershipPortal.api", Version = "v2" });
            });
            services.AddCors();
            services.Configure<RegistrationAPI_Settings>(Configuration.GetSection("RegistrationAPI_Settings"));
            services.AddScoped<IAPICredentialsService, APICredentialsService>();
            services.AddScoped<IDataService, DataService>();

            var customConfig = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            var customMapper = customConfig.CreateMapper();
            services.AddSingleton(customMapper);

            RepositoryConfiguration.Configure(services);
            ServiceConfiguration.Configure(services);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwaggerAuthorized();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v2/swagger.json", "MembershipPortal.api v2"));

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            //global error handler
            app.UseMiddleware<ErrorHandlerMiddleware>();

            //custom jwt auth middleware
            app.UseMiddleware<JwtMiddleware>();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
