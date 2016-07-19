using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProductContext : DbContext
    {



        public ProductContext() : base(MvcApplication.id == 5 ? "DefaultConnection2" : "")
        {
            

     //      Database.SetInitializer<ProductContext>(new CreateDatabaseIfNotExists<ProductContext>());

        }

        public ProductContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}

