using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace UnitTestProject1
{
    public class AppenderOptions: FilterOptions 
    {
        [XmlAttribute]
        public string name { get; set; }

        [XmlAttribute]
        public string sendWithBufferLevel { get; set; }

        [XmlAttribute]
        public string storeInBufferLevel { get; set; }

        [XmlAttribute]
        public uint bufferSize { get; set; }

        [XmlAttribute]
        public int batchSize { get; set; }

        public AppenderOptions()
        {
            storeInBufferLevel = "ALL";
            sendWithBufferLevel = "OFF";
            bufferSize = 0;
            batchSize = 1;
            level = "TRACE";
        }
    }
}
