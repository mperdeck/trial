using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;


using Microsoft.AspNetCore.Hosting.WindowsServices;
using System.ServiceProcess;
using Decideware.Logging.ServerSide;
using Decideware.Configuration;


// <<<<<<<<<<<<<<<<<<<<<<<<<<<
// Create 
// ASP.NET Core Web application
// Web Application

// install package
// Microsoft.AspNetCore
// Microsoft.AspNetCore.Hosting.WindowsServices.



namespace coreservice
{
    internal class CustomWebHostService : WebHostService
    {
        public CustomWebHostService(IWebHost host) : base(host)
        {
        }

        protected override void OnStarting(string[] args)
        {
            string environment = args[0];





            string appSettingsDir = AppContext.BaseDirectory;
            if (environment == "Development")
            {
                appSettingsDir = Path.Combine(appSettingsDir, @"..\..");
            }

            System.IO.File.WriteAllText(@"g:\temp\sc2startdir.txt", appSettingsDir);

            var builder = new ConfigurationBuilder()
                .SetBasePath(appSettingsDir)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            if (environment != "Development")
            {
                builder.AddJsonFile($"appsettings.release.json", optional: true);
            }

            var configuration = builder.Build();

            CoreConfigurationManager.Configuration = configuration;

            LoggingConfiguration.Current = CoreConfigurationManager.GetSection<LoggingConfiguration>("loggingSettings");

            // <<<<<<<<<<<<<<<<<<<<<<

            string json = JsonConvert.SerializeObject(LoggingConfiguration.Current);
            System.IO.File.WriteAllText(@"g:\temp\sc2startjson", json);





            base.OnStarting(args);
        }

        protected override void OnStarted()
        {
            base.OnStarted();
        }

        protected override void OnStopping()
        {
            base.OnStopping();
        }
    }

    public static class WebHostServiceExtensions
    {
        public static void RunAsCustomService(this IWebHost host)
        {
            var webHostService = new CustomWebHostService(host);
            ServiceBase.Run(webHostService);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var pathToExe = Process.GetCurrentProcess().MainModule.FileName;
            var pathToContentRoot = Path.GetDirectoryName(pathToExe);

            var host = WebHost.CreateDefaultBuilder(args)
                .UseContentRoot(pathToContentRoot)
                .UseStartup<Startup>()
                .Build();

            host.RunAsCustomService();
        }
    }
}
