using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using noncore1.Models;

namespace noncore1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var rows = new List<Row>();
            rows.Add(new Row() { S1 = "s1a", S2 = "s2a" });
            rows.Add(new Row() { S1 = "s1b", S2 = "s2b" });

            var theTable = new TheTable()
            {
                Rows = rows,
                Row1 = new Row { S1 = "row1-1a", S2 = "row1-2a"},
                Row2 = new Row { S1 = "row2-1a", S2 = "row2-2a" }
            };

            return View(theTable);
        }

        [HttpPost]
        public ActionResult Index(TheTable theTable)
        {

            return View(theTable);
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