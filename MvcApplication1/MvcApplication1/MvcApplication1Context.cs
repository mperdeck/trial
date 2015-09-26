using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1
{
    public class MvcApplication1Context: DbContext
    {
        public MvcApplication1Context(string connString): base(connString)
        {
        }
        
        public DbSet<Book> Books { get; set; } 
    }
}