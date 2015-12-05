using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Serilog;
using System.Web.Script.Serialization;
using System.IO;
using Serilog.Sinks.IOFile;
using Serilog.Formatting.Raw;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new
            {
                aa = 5,
                bb = "4444"
            };

    //        string s1 = @" { x: 5, y: [ ""abc"", 'def', 6] }";

    //        JavaScriptSerializer js = new JavaScriptSerializer();
    //        Object d1 = js.Deserialize<Dictionary<string, Object>>(s1);
    //     //   var d2 = js.Deserialize<Dictionary<string, Object>>(s2);

    //        string ds1 = d1.ToString();

    //        // -------------------

    ////        var log = new LoggerConfiguration()
    ////.WriteTo.ColoredConsole()
    ////.CreateLogger();

            StringBuilder sb = new StringBuilder();

            Serilog.Debugging.SelfLog.Out = new StringWriter(sb);
//            Serilog.Debugging.SelfLog.Out = Console.Out;

            var log = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.ColoredConsole()
                .WriteTo.Sink(new FileSink(@"d:\temp\log.txt", new RawFormatter(), null))
                .WriteTo.MongoDB("mongodb://localhost/logs", period: TimeSpan.Zero, batchPostingLimit: 1)
                .CreateLogger();

            log.Fatal("Fatal message223");
            log.Information("blah: {@d1}", x);


            //    .WriteTo.MongoDB("mongo://mydb/log")
            // An unhandled exception of type 'System.FormatException' occurred in MongoDB.Driver.dll

            // http://docs.mongodb.org/manual/reference/connection-string/


         //   Log.Logger = log;

         //   log.Information("Hello, Serilog2! {d1}", d1);
         ////   log.Information("Hello, Serilog2! {d2}", d2);
         //   log.Information("Hello, Serilog! {x2}", x);

         //   // -------------------

         //   stest.dosomething();

         //   stestcommon.dosomething();
        }
    }
}
