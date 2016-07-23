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
                var product = new Product();

                product.Name = "xxxxxx";
                product.Prod1 = new prod1() { p1a = "x", p1b = "y" };
                product.Prod2 = new prod2() { p2a = "x2", p2b = "y2" };

                var children = new List<Models.Child>();
                children.Add(new Child() { First = "f1", Last = "l1" });
                children.Add(new Child() { First = "f2", Last = "l2" });
                product.Children = children;

                context.Products.Add(product);
                context.SaveChanges();

                List<Product> products = context.Products.ToList();
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
//                context.Database.Delete();




                product.Prod1 = new prod1() { p1a = "x", p1b = "y" };
                product.Prod2 = new prod2() { p2a = "x2", p2b = "y2" };

                context.Products.Add(product);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}