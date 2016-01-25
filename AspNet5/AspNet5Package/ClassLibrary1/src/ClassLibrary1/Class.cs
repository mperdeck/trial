#if (!DNXCORE50 && !DNX451)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Common.Logging;

namespace ClassLibrary1
{
    public class Class
    {
        public static string getinfo()
        {
            ILog ilog = null;
            return typeof(ILog).ToString();
        }
    }
}

#endif
