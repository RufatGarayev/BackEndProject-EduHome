using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EduHome
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //    //=====Identity Start=====//
            //    services.AddIdentity<AppUser, IdentityRole>(identityOptions =>
            //    {
            //        identityOptions.Password.RequiredLength = 8;
            //        identityOptions.Password.RequireNonAlphanumeric = true; 
            //        identityOptions.Password.RequireDigit = true;
            //        identityOptions.Password.RequireLowercase = true;
            //        identityOptions.Password.RequireUppercase = true;

            //        identityOptions.User.RequireUniqueEmail = true;

            //        identityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10); 

            //        identityOptions.Lockout.MaxFailedAccessAttempts = 3;

            //        identityOptions.Lockout.AllowedForNewUsers = true; 

            //    }).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();
            //=====Identity End=====//


            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(_config["ConnectionString:Default"]);
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
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
             );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
