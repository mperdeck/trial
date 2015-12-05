using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace UnitTestProject1
{
    public class FilterOptions
    {
        [XmlAttribute]
        public string level { get; set; }

        [XmlAttribute]
        public string ipRegex { get; set; }

        [XmlAttribute]
        public string userAgentRegex { get; set; }

        [XmlAttribute]
        public string disallow { get; set; }
    }
}
