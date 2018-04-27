using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ServiceProcess;
using Decideware.Platform;
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
            //this.ServiceName = "ServerLogCopierService";
            //this.CanStop = true;
            //this.CanPauseAndContinue = false;
            //this.AutoLog = true;

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
        }

        protected override void OnStop()
        {
            //Logger logger = new Logger(this.GetType());
            //logger.LogMessage("ServerLogCopierService - stopped copying", LoggingLevel.Information);

            //serverLogCopier.StopCopying();
        }

        public static void Main()
        {
            ServiceBase.Run(new Service());
        }
    }
}

