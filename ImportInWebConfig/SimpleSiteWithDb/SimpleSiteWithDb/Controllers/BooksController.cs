﻿using SimpleSiteWithDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Web.Configuration;
using System.Collections.Specialized;

namespace SimpleSiteWithDb.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new BookStoreContext("BookStoreConnectionString"))
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
            using (var db = new BookStoreContext("BookStoreConnectionString"))
            {
                NameValueCollection test = (NameValueCollection)ConfigurationManager.GetSection("genericAppSettings");
                NameValueCollection test2 = (NameValueCollection)ConfigurationManager.GetSection("genericAppSettings2");

                string a = test["another"];



                string testkey = WebConfigurationManager.AppSettings["TestKey2"];
                book.Name += "v1:" + testkey + a;


                db.Books.Add(book);
                db.SaveChanges(); 
            }
            return View(book);
        }
    }
}


