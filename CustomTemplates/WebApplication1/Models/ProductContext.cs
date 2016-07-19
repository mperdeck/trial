using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("DefaultConnection2")
        {
     //      Database.SetInitializer<ProductContext>(new CreateDatabaseIfNotExists<ProductContext>());

        }

        public DbSet<Product> Products { get; set; }
    }
}

