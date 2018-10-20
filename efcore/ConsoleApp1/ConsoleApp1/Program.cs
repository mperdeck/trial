// using ConsoleApp1.Entities;
using ConsoleApp1.Eftest;
using System;
using System.Linq;

// https://docs.microsoft.com/en-us/ef/core/

// generate the poco classes:
// https://wildermuth.com/2017/12/20/Reverse-Engineering-Existing-Databases-in-Entity-Framework-Core-2
// this also tells you when a model cannot be generated (eg no primary key)
//
// also generates nav properties:
// Install this first:
// https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools
// then
// https://github.com/ErikEJ/EFCorePowerTools/wiki/Reverse-Engineering
// https://github.com/ErikEJ/EFCorePowerTools/wiki
// (but this doesn't tell you if model cannot be generated!)
// it just doesn't do it.
//
// doco says to update properties template for nav properties,
// but you don't have to do that anymore.

    // >>>>>>>>>>>>>>>>>
    // one column cannot be foregn key to 2 tables.
    // just point acctype to templ and templ.orgid to org.
    // in ef we'll have to join via templ
    //
    // Or: acctype points at Org, and
    // templ.Id points at Org.Id
    // So both templ.Id and templ.OrgId point at Org.Id
    // ensuring they are always the same.
    //
    // templ.Id should not be an Identity

    // ===========================
    // do not do SaveChanges after each Add. Instead, do SaveChanges once after all Adds.
    //
    // set Ids (identity fields) to 0
    //
    // all entities do not have to be in same context.
    // they will be saved,
// even though you can't call SaveChanges on the second context.   
// this is ok for People and for Templ2


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = new Country { Id = 0, CountryName = "A better place" };

            var client2 = new Client { Id = 0, ClientName = "client 2", Country = country };
            country.Clients.Add(client2);

            var templ2 = new Templ2 { Id = 0, Templ2name = "templ2name", Client = client2, IdNavigation = client2 };


            var supplier2 = new Supplier { Id = 0, SupplierName = "supplier 2" };

            var person2 = new Person { Id = 0, Surname = "person 2", MyClient = client2 };
            client2.People.Add(person2);

            var clientsupplier2 = new ClientSupplier { Id = 0,  Client = client2, Supplier = supplier2 };


            using (var db = new OptimizewareContext())
            {
                using (var db2 = new OptimizewareContext2())
                {
                    var countryInDb = db.Countries.SingleOrDefault(c => c.CountryName == "A better place");
                if (countryInDb == null)
                {
                    db.Countries.Add(country);
                }
                else
                {
                    // Repoint all entities with references to country to the newly loaded
                    // pre-existing countryInDb
                    foreach (var client in country.Clients)
                    {
                        client.Country = countryInDb;
                    }

                    // Don't copy country.Clients, because EF doesn't need it, and it will fill this in itself.
                }



                db.ClientSuppliers.Add(clientsupplier2);
                db2.People.Add(person2);
                db.Clients.Add(client2);
                db2.Templ2.Add(templ2);
                db.Suppliers.Add(supplier2);

                db.SaveChanges();
         //           db2.SaveChanges();
                }
            }






            //using (var db = new OptimizewareContext())
            //{
            //    var blogs = db.Acctypes
            //        .OrderBy(b => b.AcctypeId)
            //        .ToList();
            //}



        }
    }
}
