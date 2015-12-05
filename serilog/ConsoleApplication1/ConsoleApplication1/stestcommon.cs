using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Common.Logging;
using System.Web.Script.Serialization;

namespace ConsoleApplication1
{
    public class stestcommon
    {
        public static void dosomething()
        {

            ILog log2 = LogManager.GetLogger("logger0");
            log2.Warn("---------------------------------the log message warn");

            string s1a = @" { x2: 5, y2: [ ""abc-b"", 'def-b', 6, { ""k"": 'blah', m: 55 }, { ""k"": 'blah6', m: 56 }] }";
            ILog log3 = LogManager.GetLogger("logger1");
            log3.Warn(s1a);

            JavaScriptSerializer js = new JavaScriptSerializer();
            Object d1a = js.Deserialize<Dictionary<string, Object>>(s1a);

            ILog log4 = LogManager.GetLogger("logger2");
            log4.Warn(d1a);

            string s1bad = @" {{ x2: 5, y2: [ ""abc-b"", 'def-b', 6, { ""k"": 'blah', m: 55 }, { ""k"": 'blah6', m: 56 }] }";
            ILog log5 = LogManager.GetLogger("logger3");
            log5.Warn(s1bad);







            string s2 = @"abc def";

            Object so1 = s1a;
            if (so1 is string)
            {

            }
            else
            {

            }

            string so1a = s1a.ToString();



            //   var d2 = js.Deserialize<Dictionary<string, Object>>(s2);


            // -------------------

            //ILog log2 = LogManager.GetLogger("the logger name 0");
            //log2.Warn("---------------------------------the log message warn");

            //ILog log = LogManager.GetLogger("the logger name 1");
            //log.Info(d1a);

            //ILog log3 = LogManager.GetLogger("the logger name 2");
            //log3.Error("the log message");

            //Log.Information("Hello, Serilog using static Log -- 2! {d1a}", d1a);
            //Log.Information("{d1a}", d1a);
            //   log.Information("Hello, Serilog2! {d2}", d2);
        }
    }
}
