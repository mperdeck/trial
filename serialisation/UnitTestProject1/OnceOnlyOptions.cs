﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace UnitTestProject1
{
    public class OnceOnlyOptions
    {
        [XmlAttribute]
        public string regex { get; set; }
    }
}
