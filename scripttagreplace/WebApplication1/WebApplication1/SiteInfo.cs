using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class SiteInfo: ISiteInfo
    {
        public string GetVersion {
            get
            {
                return "release15-5698";
            }
        }
    }
}
