using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop.Models;

namespace Shop
{
    public class Startup
    {
        internal static int _cartPosition = 0;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyDbContext>();
            services.AddMvc();
            services.AddRazorPages();
            services.AddSession();
            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseExceptionHandler("/../ClassLibrary/Error");
            app.UseRouting();
            new DatabaseObjects().Insert();
            app.UseSession();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Main}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
