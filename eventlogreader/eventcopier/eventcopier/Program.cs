using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace eventcopier
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventLogWatcher = new EventLogWatcher("Application");
            eventLogWatcher.EventRecordWritten += eventLoggedHandler;


            Console.WriteLine("listening for events. Hit any key to exit.");
            Console.ReadKey();
        }

        public static void eventLoggedHandler(object sender, EventRecordWrittenEventArgs e)
        {
            var id = e.EventRecord.Id;

            Console.WriteLine($"got event {id}");
            return;
        }
    }
}


