﻿using FiltersSample.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using FiltersSample.Helper;

namespace FiltersSample.Controllers
{
    public class HomeController : BaseController
    {
        #region snippet_ServiceFilter
     //   [ServiceFilter(typeof(AddHeaderFilterWithDi))]
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        public IActionResult Hello(string name)
        {
            return Content($"Hello {name}");
        }

        #region snippet_TypeFilter
  //      [TypeFilter(typeof(AddHeaderAttribute), Arguments = new object[] { "Author", "Steve Smith (@ardalis)" })]
        public IActionResult Hi(string name)
        {
            return Content($"Hi {name}");
        }
        #endregion

        #region snippet_MiddlewareFilter
        [Route("{culture}/[controller]/[action]")]
     //   [MiddlewareFilter(typeof(LocalizationPipeline))]
        public IActionResult CultureFromRouteData()
        {
            return Content($"CurrentCulture:{CultureInfo.CurrentCulture.Name},"
                + "CurrentUICulture:{CultureInfo.CurrentUICulture.Name}");
        }
        #endregion
    }
}
