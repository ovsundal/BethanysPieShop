using BethanysPieShop.Models;
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
            services.AddTransient<IPieRepository, MockPieRepository>();     //whenever someone is asking for an IPieRepo, new instance of MockPieRepo will be returned
            //services.AddSingleton                                         //only one single instance is going to be created of the type, same instance will always be returned
            //services.AddScoped                                            //returnes the same instance. If request goes out of scope, instance is removed and with the next request, a new instance will be returned

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
