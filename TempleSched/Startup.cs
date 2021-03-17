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
using TempleSched.Models;

namespace TempleSched
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ListContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionString:ListConnection"]);
            });
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
                //changes url to just say /appointments when on appointments page
                endpoints.MapControllerRoute(
                    "appointmentsPage",
                    "appointments",
                    new { Controller = "Home", action = "ViewAppointment" });
                //changes url to say /times when on time choosing page
                endpoints.MapControllerRoute(
                    "chooseTime",
                    "times",
                    new { Controller = "Home", action = "Times" });
                //added this as appointments because it is also shown on the appointments page when the previous page passes to it
                endpoints.MapControllerRoute(
                    "chooseTime",
                    "appointments",
                    new { Controller = "Home", action = "TimeForm" });
                //default endpoint
                endpoints.MapDefaultControllerRoute();


            });
        
        }
    }
}
