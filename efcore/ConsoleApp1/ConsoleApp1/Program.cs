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



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var client2 = new Client { Id = 0, ClientName = "client 2" };

            var supplier2 = new Supplier { Id = 0, SupplierName = "supplier 2" };

            var person2 = new Person { Id = 0, Surname = "person 2", MyClient = client2 };
            client2.People.Add(person2);

            var clientsupplier2 = new ClientSupplier { Id = 0,  Client = client2, Supplier = supplier2 };






            using (var db = new OptimizewareContext())
            {
                db.People.Add(person2);
                db.Clients.Add(client2);

                db.SaveChanges();
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
