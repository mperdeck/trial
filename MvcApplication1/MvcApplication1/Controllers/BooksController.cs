using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new MvcApplication1Context("MvcApplication1"))
            {
                return View(db.Books.ToList());
            } 
        }

        [HttpGet]
        public ActionResult Add()
        {
            Book book = new Book();
            return View(book);
        }

        [HttpPost]
        public ActionResult Add(Book book)
        {
            using (var db = new MvcApplication1Context("MvcApplication1"))
            {
                db.Books.Add(book);
                db.SaveChanges(); 
            }
            return View(book);
        }
    }
}


