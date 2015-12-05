using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace UnitTestProject1
{
    [XmlRoot("jsnlog")]
    public class JsnlogConfiguration
    {
        [XmlAttribute]
        public bool enabled { get; set; }

        [XmlAttribute]
        public int maxMessages { get; set; }

        [XmlAttribute]
        public string defaultAjaxUrl { get; set; }

        [XmlAttribute]
        public string corsAllowedOriginsRegex { get; set; }

        [XmlAttribute]
        public string serverSideLogger { get; set; }

        [XmlAttribute]
        public string serverSideLevel { get; set; }

        [XmlAttribute]
        public string serverSideMessageFormat { get; set; }

        [XmlAttribute]
        public string dateFormat { get; set; }

        [XmlAttribute]
        public string productionLibraryPath { get; set; }

        [XmlElement("logger")]
        public List<Logger> loggers = new List<Logger>();

        [XmlElement("ajaxAppender")]
        public List<AjaxAppender> ajaxAppenders = new List<AjaxAppender>();

        [XmlElement("consoleAppender")]
        public List<ConsoleAppender> consoleAppenders = new List<ConsoleAppender>();

        public JsnlogConfiguration()
        {
            // Set default values. If an element is not given in the XML or JSON,
            // the deserializer will simply not set it.
            enabled = true;
            maxMessages = int.MaxValue;
            serverSideMessageFormat = "%message";
            dateFormat = "o";
            defaultAjaxUrl = "/jsnlog.logger";
        }
    }
}
