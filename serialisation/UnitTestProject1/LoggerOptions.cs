using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace UnitTestProject1
{
    public class Logger: FilterOptions
    {
        [XmlAttribute]
        public string appenders { get; set; }

        [XmlAttribute]
        public string name { get; set; }

        [XmlElement("onceOnly")]
        public List<OnceOnlyOptions> onceOnlies = new List<OnceOnlyOptions>();
    }
}
