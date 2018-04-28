using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ServiceProcess;
using Decideware.Platform;


// Create a Core Console program project //<<<<<<<<<<<<<<<<<<<<<<<<
// ADD package Microsoft.Extensions.Configuration.Json

// uses Microsoft.ApplicationInsights nuget package    
using Microsoft.ApplicationInsights.Extensibility.Implementation;    //<<<<<<<<<<<<<<<<<<<<<<<<
using Decideware.Logging.ServerSide;
using Decideware.Configuration;
using Microsoft.Extensions.Configuration;

using System;
using System.IO;
using System.Text;   //<<<<<<<<<<<<<<<<<<<<<<<<


using Newtonsoft.Json;

//using Decideware.Logging.ServerSide;
//using Decideware.Logging.ServerSide.Net4;

// -------------------------------------------------------------------------------------
// This is currently still a non-Core application, because at the time of writing
// Windows Services are poorly supported by .Net Core.
//
// See
// https://docs.microsoft.com/en-gb/aspnet/core/host-and-deploy/windows-service
//
//TODO: Convert to .Net Core application
// -------------------------------------------------------------------------------------

/// <summary>
/// Information on how to create a Windows Service, and how to start/stop it:
/// https://docs.microsoft.com/en-us/dotnet/framework/windows-services/
/// http://www.i-programmer.info/projects/38-windows/276-a-windows-service-without-a-template.html?start=1
/// https://www.codeproject.com/Articles/106742/Creating-a-simple-Windows-Service
/// </summary>
namespace Decideware.Platform.ServerLogCopierService
{
    /// <summary>
    /// This windows service monitors the server logs. When a new entry is written to the server logs, it copies that entry
    /// to our application log. This way, our application logs contain all logs.
    /// 
    /// The specific logs to monitor are specified in the app.config file.
    /// 
    /// Like any windows service, this service has to be installed. Scripts to do this are in 
    /// E:\Dev\DeploymentScripts\ServerConfiguration
    /// </summary>

    public class Service : ServiceBase
    {
        //private ServerLogToApplicationLogCopier serverLogCopier = null;

        public Service()
        {
            this.ServiceName = "service";
            this.CanStop = true;
            this.CanPauseAndContinue = false;
            this.AutoLog = true;

            //string commaSeparatedLogNames = ConfigurationManager.AppSettings["LogNames"];
            //if (commaSeparatedLogNames == null)
            //{
            //    throw new Exception("ServerLogCopierService: LogNames not found in AppSettings in app.config.");
            //}

            //string[] logNames = commaSeparatedLogNames.Split(',');
            //serverLogCopier = new ServerLogToApplicationLogCopier(logNames);
        }

        protected override void OnStart(string[] args)
        {
            //Logger logger = new Logger(this.GetType());
            //logger.LogMessage($"ServerLogCopierService - started copying {string.Join(", ", serverLogCopier.LogNames)}", LoggingLevel.Information);

            //serverLogCopier.StartCopying();


            // test code
            string json = JsonConvert.SerializeObject(LoggingConfiguration.Current);
            System.IO.File.WriteAllText(@"g:\temp\wsstart.txt", json);

        }

        protected override void OnStop()
        {
            //Logger logger = new Logger(this.GetType());
            //logger.LogMessage("ServerLogCopierService - stopped copying", LoggingLevel.Information);

            //serverLogCopier.StopCopying();
        }

        public static void Main()
        {
            TelemetryDebugWriter.IsTracingDisabled = true; //<<<<<<<<<<<<<<<<<<<<<<<<


            // <<<<<<<<<<<<<<<<<< create library method for console programs
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(AppContext.BaseDirectory))
                .AddJsonFile("appsettings.json", optional: true);

            System.IO.File.WriteAllText(@"g:\temp\wsbasedir.txt", AppContext.BaseDirectory);


            // The script that starts the service has to set this environment variable
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (environment != "Development")
            {
                builder
                    .AddJsonFile($"appsettings.release.json", optional: false);
                builder
                    .AddJsonFile($"appsettings.{environment}.json", optional: false);
            }

            CoreConfigurationManager.Configuration = builder.Build();



            // <<<<<<<<<<<<<<<<<<<<
            LoggingConfiguration.Current = CoreConfigurationManager.GetSection<LoggingConfiguration>("loggingSettings");



            // test code
            string json = JsonConvert.SerializeObject(LoggingConfiguration.Current);
            System.IO.File.WriteAllText(@"g:\temp\wsmain.txt", json);



            ServiceBase.Run(new Service());
        }
    }
}

