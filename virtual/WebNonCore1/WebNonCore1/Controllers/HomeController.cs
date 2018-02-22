using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebNonCore1.Models;

namespace WebNonCore1.Controllers
{
    public class HomeController : Controller
    {
        class c1
        {
            int i;
        }

        class c2: c1
        {
            int i2;
        }

        public ActionResult Index()
        {
            var c = HttpContext;
            var u = c.User;

            var v2 = new c2();

            bool b2 = v2 is c2;
            bool b = v2 is c1;

            return View();
        }



        public JsonResult About4()
        {
            return new JsonResultMessage(HttpStatusCode.BadRequest);
        }

        public JsonResult About2()
        {
            return Json(new JsonResultMessage(HttpStatusCode.Forbidden), JsonRequestBehavior.AllowGet);
        }

        public JsonResult About3()
        {
            bool success = true;
            return Json(new JsonResultMessage(success), JsonRequestBehavior.AllowGet);
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