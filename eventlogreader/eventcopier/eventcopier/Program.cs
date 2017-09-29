using System;
using System.Collections.Generic;
using System.Diagnostics;
//using Newtonsoft.Json;

using Serilog;
using Serilog.Events;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace eventcopier
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (!EventLog.SourceExists("testsrc"))
            //{
            //    EventLog.CreateEventSource("testsrc", "Application");
            //}

            var logger = new LoggerConfiguration()
                            .WriteTo.LiterateConsole()
                            .CreateLogger();
            Log.Logger = logger;
            Log.Information("The global logger has been configured");

            // -----------------

            var logs = new List<EventLog> ();

            var names = new string[] {
                "Application",
                "System",
            };
            foreach (var n in names)
            {
                var log = new EventLog(n);
                log.EnableRaisingEvents = true;
                log.EntryWritten += new EntryWrittenEventHandler(OnEntryWritten);
                logs.Add(log);
                Console.WriteLine("added {0}", n);
            }

            Console.WriteLine("listening for events. Hit any key to exit.");
            Console.ReadKey();
        }

        protected static void OnEntryWritten(object source, EntryWrittenEventArgs evt)
        {
            // event type (information, etc)
            // https://msdn.microsoft.com/en-us/library/system.diagnostics.eventlogentrytype(v=vs.110).aspx
            // https://msdn.microsoft.com/en-us/library/system.diagnostics.eventlogentry.entrytype(v=vs.110).aspx


            var e = evt.Entry;
            Console.WriteLine("got {0}: {1}", e.Source, e.Message);
            var v = new
            {
                EntryType = e.EntryType,
                Index = e.Index,
                InstanceId = e.InstanceId,
                MachineName = e.MachineName,
                Message = e.Message,
                Source = e.Source,
                TimeGenerated = e.TimeGenerated.ToUniversalTime(),
                TimeWritten = e.TimeWritten.ToUniversalTime(),
                UserName = e.UserName,
            };

            Log.Error("Here is the log: {@e}", e);




            //var msg = JsonConvert.SerializeObject(v);
            //Console.WriteLine(msg);
        }
    }
}


