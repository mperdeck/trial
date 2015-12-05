using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Script.Serialization;

namespace SimpleLog.Controllers.Logger
{
    public class LoggerController : Controller
    {
        public class LogItem
        {
            public string logger { get; set; }
            public string timestamp { get; set; }
            public string level { get; set; }
            public string url { get; set; }
            public IEnumerable<string> message { get; set; }
        }

        //public class LogItems : List<LogItem>
        //{
        //}

        public class LogItems : List<Dictionary<string, Object>>
        {
        }

        //
        // GET: /Default/

        public ActionResult Index(string data)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();

            LogItems logItems = js.Deserialize<LogItems>(data);


            return Json("ok", "text/x-json", System.Text.Encoding.UTF8);
        }

    }
}
