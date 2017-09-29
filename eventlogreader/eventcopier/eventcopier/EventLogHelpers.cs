using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace eventcopier
{
    public class EventLogHelpers
    {
        public static void Subscribe(Action<Object> eventLogged, params string[] logName)
        {
            var eventLogWatcher = new EventLogWatcher("Application");
            eventLogWatcher.EventRecordWritten += eventLoggedHandler;



        }

        public static void eventLoggedHandler(object sender, EventRecordWrittenEventArgs e)
        {
            return;
        }
    }
}
