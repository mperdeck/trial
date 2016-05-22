using SimpleSiteWithDb;
using SimpleSiteWithDb.Migrations;
using System.Data.Entity;

namespace BlueChilli.CTARS.Service
{
    public static class DatabaseInitialization
    {
        public static void Initialize()
        {
            Database.SetInitializer<BookStoreContext>(new MigrateDatabaseToLatestVersion<BookStoreContext, Configuration>());

            using (var db = new BookStoreContext("BookStoreConnectionString"))
            {
                db.Database.Initialize(true);
            }
        }
    }
}
