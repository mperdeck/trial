using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data.Entity.Migrations;



namespace WebApplication1.Models
{
    public class Configuration : DbMigrationsConfiguration<ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ProductContext context)
        {
        }

    }
}