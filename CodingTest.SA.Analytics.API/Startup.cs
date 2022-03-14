using CodingTest.SA.Analytics.API.Mappings.AutoMapper.Configuration;
using CodingTest.SA.Analytics.DataAccess.Contexts;
using CodingTest.SA.Analytics.DataAccess.Contexts.Interfaces;
using CodingTest.SA.Analytics.DataAccess.Repositories;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;
using CodingTest.SA.Analytics.Services;
using CodingTest.SA.Analytics.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.API
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
            IConfigurationRoot config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            services.AddControllersWithViews();
            services.AddAutoMappingSetup();

            services.AddDbContext<AnalyticsDbContext>(options => options.UseSqlServer(config.GetSection("DBConnectionString").Value, s => { s.EnableRetryOnFailure(); s.CommandTimeout(180); }));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IAnalyticsDbContext, AnalyticsDbContext>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<IModelRepository, ModelRespository>();
            services.AddScoped<INewTradeActionRepository, NewTradeActionRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();

            services.AddScoped<IContractService, ContractService>();
            services.AddScoped<IModelService, ModelService>();
            services.AddScoped<INewTradeActionService, NewTradeActionService>();
            services.AddScoped<IPositionService, PositionService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
