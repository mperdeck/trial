using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new ProductContext())
            {
                IEnumerable<Product> products = context.Products.ToList();
                return View(products);
            }
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            using (var context = new ProductContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}