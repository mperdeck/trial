﻿using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;
using UsingOptions.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace UsingOptions.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IOptions<MyOptions> optionsAccessor)
        {
            //      Options = optionsAccessor.Value;
            OptionsAccessor = optionsAccessor;
        }

        //   MyOptions Options { get; }
        IOptions<MyOptions> OptionsAccessor { get; }


        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(OptionsAccessor.Value);
        }
    }
}
