﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
using System.Runtime;

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
#elif DNX45
            return "dnx45";
#else
      return "net40";
#endif
        }
    }
}
