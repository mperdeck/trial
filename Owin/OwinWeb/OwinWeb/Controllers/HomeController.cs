using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace OwinWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ILog log = LogManager.GetLogger("serverlogger");
            log.Info("Info Message generated on server");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}