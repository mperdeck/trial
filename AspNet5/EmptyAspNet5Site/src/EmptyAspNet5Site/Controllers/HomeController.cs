using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ClassLibrary1;

namespace EmptyAspNet5Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string x = TestClass.GetSomething();

            int y = 0;

#if DNXCORE50
            y=1;
#elif DNX451
            y=2;
#else
            y = 3;
#endif

            int z = y;


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
