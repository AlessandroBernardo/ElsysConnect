using ElsysConnect.Web.AutoMapper;
using ElsysConnect.Application;
using ElsysConnect.Application.Interfaces;
using ElsysConnect.Domain.Interfaces;
using ElsysConnect.Infra.Data.Repository;
using ElsysConnect.Web.Models.ElsysConnectModel;
using Infra.Data.ContextDb;
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
using System.Data;
using Microsoft.Data.SqlClient;

namespace ElsysConnect.Web
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
            //services.AddDbContext<Context>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionDefault")));
            services.AddScoped<IDbConnection>(db => new SqlConnection(Configuration.GetConnectionString("ConnectionDefault")));

            services.AddAutoMapper(typeof(AutoMapperSetup));         
          
            services.AddScoped<ICandidateAppService, CandidateAppService>();
            services.AddScoped<ICandidateRepository, CandidateRepository>();

            services.AddScoped<IJobPositionAppService, JobPositionAppService>();
            services.AddScoped<IJobPositionRepository, JobPositionRepository>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IBaseAppService<>), typeof(BaseAppService<>));                        
            
            services.AddControllersWithViews();
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
