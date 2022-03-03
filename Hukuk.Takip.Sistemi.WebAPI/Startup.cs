using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hukuk.Takip.Sistemi.Entities.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Hukuk.Takip.Sistemi.DataAccess.Abstract;
using Hukuk.Takip.Sistemi.DataAccess.Concrete;
using MediatR;
using System.Reflection;

namespace Hukuk.Takip.Sistemi.WebAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            services.AddDbContext<HukukTakipDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddScoped<IMusteriService, MusteriService>();
            services.AddScoped<IMusteriAdresService, MusteriAdresService>();
            services.AddScoped<IMusteriTelefonService, MusteriTelefonService>();
            services.AddScoped<IMusteriUrunService, MusteriUrunService>();
            services.AddScoped<IIhtarService, IhtarService>();
            services.AddScoped<IIhtarUrunService, IhtarUrunService>();
            services.AddScoped<IAvukatService, AvukatService>();
            services.AddScoped<IAvukatAtananUrunService, AvukatAtananUrunService>();
            services.AddScoped<IIcraTakipService, IcraTakipService>();
           

            var assembly = AppDomain.CurrentDomain.Load("Hukuk.Takip.Sistemi.App");
            services.AddMediatR(assembly);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HukukTakipSistemi.WebAPI", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "HukukTakipSistemi.WebAPI V1");
            });
            app.UseMvc();
        }
    }
}
