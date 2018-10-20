using ConsoleApp1.Entities;
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
            using (var db = new OptimizewareContext())
            {
                var blogs = db.Acctypes
                    .OrderBy(b => b.AcctypeId)
                    .ToList();
            }



        }
    }
}
