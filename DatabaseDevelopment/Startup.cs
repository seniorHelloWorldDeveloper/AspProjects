using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using ClassLibrary.Helpers;
using DatabaseDevelopment.Attributes;
using DatabaseDevelopment.Controllers;
using DatabaseDevelopment.Helpers;
using DatabaseDevelopment.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace DatabaseDevelopment
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyDbContext>();
            services.AddMvc();
            services.AddRazorPages();
            services.AddSession();
            services.AddMvc(new Action<MvcOptions>(x => {
                x.EnableEndpointRouting = false;
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.Use(async (context, next) => {
                Type type = default;
                MethodInfo method = default;
                try{
                    type = Type.GetType($"DatabaseDevelopment.Controllers.{context.Request.RouteValues["controller"].ToString()}Controller"); 
                    method = type.GetMethods().Where(x => x.Name == $"{context.Request.RouteValues["action"].ToString()}").First();
                }
                catch (NullReferenceException){
                    context.Response.StatusCode = 404;
                    return;
                }
                //Обработка атрибута HasRole
                if (method.HasAttribute(typeof(HasRole))){
                    bool isValid = true;
                    var user = new SessionHelper<User>(context.Session)["user"];
                    IEnumerable<bool> Validates = new List<bool>();
                    foreach (var attr in method.GetCustomAttributes(typeof(HasRole), false)){
                        if ((attr is null) || (!(attr as HasRole).IsValid(user, "admin")))
                            isValid = false;
                        
                        else
                            Validates.Append(true);
                        
                    }
                    if (!isValid || method.GetCustomAttributes(false).Length == Validates.Count())
                    {
                        context.Response.StatusCode = 404;
                        return;
                    }
                }

                //Обработка атрибута RequireConnectionString
                if (method.HasAttribute(typeof(RequireConnectionString))){
                    var connString = new SessionHelper<ConnectionString>(context.Session)["connString"];
                    if (connString is null){
                        await context.Response.WriteAsync("Вы не подключены к базе данных!");
                        return;
                    }
                }
                await next.Invoke();
            });

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}");
            });
        }
    }
}
