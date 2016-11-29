using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


using WebApplication1.Models;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static int id = 5;


        protected void Application_Start()
        {
            ReadOnlyCollection<TimeZoneInfo> timeZones = TimeZoneInfo.GetSystemTimeZones();
            var ids = timeZones.Select(i => i.Id);
            var names = timeZones.Select(i => i.StandardName);



            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);





       //     var initializer = new DropCreateAndMigrateDatabaseInitializer<ProductContext, Configuration>();

            var initializer = new MigrateDatabaseToLatestVersion<ProductContext, Configuration>();
            Database.SetInitializer<ProductContext>(initializer);

            using (var ctx = new ProductContext("DefaultConnection2"))
            {
                ctx.Database.Initialize(force: true);
            }





            //Database.SetInitializer<ProductContext>(new MigrateDatabaseToLatestVersion<ProductContext, Configuration>());
            //using (var db = new ProductContext())
            //{
            //    db.Database.Delete();
            //    db.Database.Initialize(true);
            //}



        }
    }
}
