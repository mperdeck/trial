using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Serilog;
using System.Web.Script.Serialization;

namespace ConsoleApplication1
{
    public class stest
    {
        public static void dosomething()
        {
            string s1a = @" { x: 5, y: [ ""abc-a"", 'def-a', 6] }";
            string s2 = @"abc def";

            JavaScriptSerializer js = new JavaScriptSerializer();
            Object d1a = js.Deserialize<Dictionary<string, Object>>(s1a);
            //   var d2 = js.Deserialize<Dictionary<string, Object>>(s2);


            // -------------------


            Log.Information("Hello, Serilog using static Log -- 2! {d1a}", d1a);
            Log.Information("{d1a}", d1a);
            //   log.Information("Hello, Serilog2! {d2}", d2);
        }
    }
}
