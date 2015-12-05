using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace UnitTestProject1
{
    public class AjaxAppender: AppenderOptions
    {
        [XmlAttribute]
        public string url { get; set; }

        public AjaxAppender()
        {
            // Set default values. If an element is not given in the XML or JSON,
            // the deserializer will simply not set it.
            url = "/jsnlog.logger";
        }
    }
}
