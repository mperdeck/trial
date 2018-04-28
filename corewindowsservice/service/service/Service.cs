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


//<<<<<<<<<<<<<<<<<<<<<<<<
// Add logNames to appsettings files


using Newtonsoft.Json;
using System.Collections;

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
    public class AppSettings
    {
        public string logNames;
        public LoggingConfiguration loggingSettings;
    }




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
            // You cannot pass environment variables to windows services. So pass it as a parameter in the call to
            // sc.exe start
            // See https://stackoverflow.com/questions/31414578/set-environment-variable-for-windows-service
            string environment = args[0];

            string appSettingsFile =
                (environment == "Development") ? @"..\..\appsettings.json" : "appsettings.release.json";

            string appSettingsPath = Path.Combine(AppContext.BaseDirectory, appSettingsFile);

            string json = System.IO.File.ReadAllText(appSettingsPath);

            AppSettings appSettings = JsonConvert.DeserializeObject<AppSettings>(json);

            LoggingConfiguration.Current = appSettings.loggingSettings;

            string logSections = appSettings.logNames;



            System.IO.File.WriteAllText(@"g:\temp\wsenv.txt", appSettingsPath);
            System.IO.File.WriteAllText(@"g:\temp\wsenv2.txt", logSections);
            System.IO.File.WriteAllText(@"g:\temp\wsenv3.txt", json);






            //Logger logger = new Logger(this.GetType());
            //logger.LogMessage($"ServerLogCopierService - started copying {string.Join(", ", serverLogCopier.LogNames)}", LoggingLevel.Information);

            //serverLogCopier.StartCopying();


            //        System.IO.File.WriteAllText(@"g:\temp\wsstartarg.txt", args[0]);





            //        // <<<<<<<<<<<<<<<<<< create library method for console programs

            //        var builder = new ConfigurationBuilder()
            //.SetBasePath(Path.Combine(AppContext.BaseDirectory))
            //.AddJsonFile(@"..\..\appsettings.json", optional: true);

            //        System.IO.File.WriteAllText(@"g:\temp\wsbasedir.txt", AppContext.BaseDirectory);



            //        IDictionary environments = Environment.GetEnvironmentVariables();

            //        




            //        if (environment != "Development")
            //        {
            //            //builder
            //            //    .AddJsonFile($@"..\..\appsettings.release.json", optional: false);
            //            //builder
            //            //    .AddJsonFile($@"..\..\appsettings.{environment}.json", optional: false);
            //        }

            //        CoreConfigurationManager.Configuration = builder.Build();



            // <<<<<<<<<<<<<<<<<<<<
            //   LoggingConfiguration.Current = CoreConfigurationManager.GetSection<LoggingConfiguration>("loggingSettings");



            // test code
            string json2 = JsonConvert.SerializeObject(LoggingConfiguration.Current);
            System.IO.File.WriteAllText(@"g:\temp\wsmain.txt", json2);













            // test code
            //string json = JsonConvert.SerializeObject(LoggingConfiguration.Current);
         //   System.IO.File.WriteAllText(@"g:\temp\wsstart.txt", json);

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



            ServiceBase.Run(new Service());
        }
    }
}

