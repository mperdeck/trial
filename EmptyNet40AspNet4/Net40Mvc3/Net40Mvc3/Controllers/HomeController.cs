using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1;

namespace Net40Mvc3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            string netVersion = Environment.Version.ToString();
            string x = TestClass.GetSomething();


            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
