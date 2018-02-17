using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using core1.Models;

//#################
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http;


//################
using Microsoft.Extensions.Primitives;

namespace core1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var p = HttpContext.Request.Path;
            var p2 = HttpContext.Request.PathBase;
            ViewBag.p1 = Url.Content("~/");
            ViewBag.p2 = p.Value;
            ViewBag.p3 = p2.Value;
            ViewBag.p4 = HttpContext.Request.GetDisplayUrl();
            ViewBag.p5 = HttpContext.Request.GetEncodedUrl();


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var p = HttpContext.Request.Path;
            var p2 = HttpContext.Request.PathBase;
            ViewBag.p1 = Url.Content("~/");    // virtual path, eg. /core1
            ViewBag.p2 = p.Value;    // absolutpath, eg. /Home/About

            ViewBag.p3 = p2.Value;    // virtual path, eg. /core1 (but if not in sub app, this is empty, while ~ gives /)

            //core: no sub app
            //p1: /
            //p2: /Home/About
            //p3:
            //p4: http://localhost:8200/Home/About
            //p5: http://localhost:8200/Home/About

            //core sub app:
            /*
             * p1: /core1/

            p2:

            p3: /core1

            p4: http://localhost:8202/core1

            p5: http://localhost:8202/core1


            Microsoft Azure
            Learn how Microsoft's Azure cloud platform allows you to build, deploy, and scale web apps. Learn More

            -----------------------------------

            p1: /core1/

p2: /Home/About

p3: /core1

p4: http://localhost:8202/core1/Home/About

p5: http://localhost:8202/core1/Home/About

             * 
             * */


            // note that for non-core 
            //application path: /noncore1
            //HttpRuntime.AppDomainAppVirtualPath = /noncore1


            ViewBag.p4 = HttpContext.Request.GetDisplayUrl(); // full url, eg. http://localhost:8202/core1/Home/About
            ViewBag.p5 = HttpContext.Request.GetEncodedUrl();

            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /************
        [HttpPost]
        public IActionResult Contact(ViewModel viewModel)
        {
            var modelState = ModelState;

            var value = ModelState["String1"].AttemptedValue;

            ModelState.SetModelValue("StringNew", value, value);
            ModelState.Remove("String1");

            var value2 = ModelState["StringNew"].AttemptedValue;

            ViewData["Message"] = "Your contact page.";

            return View();
        }
        **************/


        [HttpPost]
        public IActionResult Contact(IFormCollection collection) //<<<<<<<<<<<<<<<<<
        {
            var string1value = collection["String1"];

            //       collection["FunctionId"] = "jjjhhgg";

            var values = collection.ToList();
//            var dict = new Dictionary<string, StringValues>(values);
            var dict = new Dictionary<string, StringValues>(collection);
            dict.Add("FunctionId", new StringValues("jjjhhgg"));


            var newFormCollection = new FormCollection(dict);



            var newValue = newFormCollection["FunctionId"];

            ViewData["Message"] = "Your contact page.";

            return View();
        }




        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
