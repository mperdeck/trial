using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base()
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}

