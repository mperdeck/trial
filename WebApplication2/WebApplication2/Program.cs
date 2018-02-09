using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureServices((services) =>
            {
                services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            })
            .ConfigureLogging((hostingContext, logging) =>
            {
                // Build the intermediate service provider
                var sp = logging.Services.BuildServiceProvider();
                var service = sp.GetService<IHttpContextAccessor>();


                // returns null if there is no context. no exception.
                var httpContext = service.HttpContext;


                logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                logging.AddConsole();
                logging.AddDebug();
            })
            .UseStartup<Startup>()
                .Build();
    }
}
