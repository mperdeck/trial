using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Net40Mvc3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            string x1 = System.Web.VirtualPathUtility.ToAbsolute("~/");
            string x2 = System.Web.VirtualPathUtility.ToAbsolute("~/abc.jpg");
            string x3 = System.Web.VirtualPathUtility.ToAbsolute("~/def/abc.jpg");


            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
