using SimpleSiteWithDb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleSiteWithDb
{
    public class BookStoreContext: DbContext
    {
        public BookStoreContext()
            : this("BookStoreConnectionString")
        {
        }

        public BookStoreContext(string connString)
            : base(connString)
        {
        }
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Booklet> Booklets { get; set; }
        public DbSet<Booklet2> Booklet2s { get; set; }
        public DbSet<Booklet3> Booklet3s { get; set; }
        public DbSet<Booklet4> Booklet4s { get; set; }
       public DbSet<Booklet5> Booklet5s { get; set; }
    }
}