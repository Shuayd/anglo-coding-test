using CodingTest.SA.Analytics.DataAccess.Contexts;
using CodingTest.SA.Analytics.DataAccess.Contexts.Interfaces;
using CodingTest.SA.Analytics.DataAccess.Repositories;
using CodingTest.SA.Analytics.DataAccess.Repositories.Interfaces;
using CodingTest.SA.Analytics.Services;
using CodingTest.SA.Analytics.Services.Interfaces;
using CodingTest.SA.Analytics.WebAPI.Mappings.AutoMapper.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTest.SA.Analytics.WebAPI
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
            services.AddCors();
            services.AddControllers();
            services.AddAutoMappingSetup();
            services.AddDbContext<AnalyticsDbContext>(options => options.UseInMemoryDatabase(databaseName: "Analytics"));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IAnalyticsDbContext, AnalyticsDbContext>();
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<IModelRepository, ModelRespository>();
            services.AddScoped<INewTradeActionRepository, NewTradeActionRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<ICommodityRepository, CommodityRepository>();
            services.AddScoped<IModelResultRepository, ModelResultRepository>();

            services.AddScoped<IContractService, ContractService>();
            services.AddScoped<IModelService, ModelService>();
            services.AddScoped<INewTradeActionService, NewTradeActionService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<ICommodityService, CommodityService>();
            services.AddScoped<IModelResultService, ModelResultService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(opts => opts.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed((host) => true).AllowCredentials().WithExposedHeaders("Content-Disposition"));
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
