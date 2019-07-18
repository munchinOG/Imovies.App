 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Imovie.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();


            app.UseMvc((routes) => 
            {
                routes.MapRoute("areaRoute", "{area=exists}/{controller=Dashboard}/{action=index}/{id?}");

                routes.MapRoute("default", "{controller=home}/{action=index}/{id?}");
            });
        }

    }
}
