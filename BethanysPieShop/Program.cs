using BethanysPieShop.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BethanysPieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BuildWebHost(args).Run();   //set up environment

            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    DbInitializer.Seed(context);
                }
                catch (Exception)
                {
                    //can log in real-world situation
                }

                host.Run();
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)  //setup app based on defaults
                .UseStartup<Startup>()  //points to startup class
                .Build();
    }
}
