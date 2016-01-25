//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.Runtime;

#if (!DNXCORE50 && !DNX451)
using Common.Logging;
#endif

namespace ClassLibrary1
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class TestClass
    {
        public static string GetSomething()
        {



#if DNXCORE50
            return "dnxcore50";
#elif DNX451
            return "dnx451";
#else
            ILog ilog = LogManager.GetLogger("cccc");
      return "net40 " + ilog.ToString() + Class.getinfo();
#endif
        }
    }
}
