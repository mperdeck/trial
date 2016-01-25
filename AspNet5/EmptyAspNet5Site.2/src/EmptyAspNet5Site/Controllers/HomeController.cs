using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Server.Kestrel;
using System.Diagnostics;

namespace EmptyAspNet5Site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var context = new ServiceContext();
            var kestrel = new KestrelEngine(context);

            Process cmd = new Process();
            //cmd.StartInfo.FileName = "cmd.exe";
            //cmd.StartInfo.RedirectStandardInput = true;
            //cmd.StartInfo.RedirectStandardOutput = true;
            //cmd.StartInfo.CreateNoWindow = true;
            //cmd.StartInfo.UseShellExecute = false;
        //    cmd.Start();


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
