using Google.Application.Configurations.Systems;
using Google.Application.Extensions;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Google.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args)
                .Initialize<AppInitializer>()
                .Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }
    }
}