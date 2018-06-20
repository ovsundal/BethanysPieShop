using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShop
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //middleware components - sequence is important
            app.UseDeveloperExceptionPage();    //adds exception when something goes wrong in app - ONLY use in dev mode
            app.UseStatusCodePages();           //show info about status of request (e.g. status 400 or 500)
            app.UseStaticFiles();               //search wwwroot by default and return static file from there
            app.UseMvcWithDefaultRoute();       
        }
    }
}
