using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace BethanysPieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();   //set up environment
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)  //setup app based on defaults
                .UseStartup<Startup>()  //points to startup class
                .Build();
    }
}
