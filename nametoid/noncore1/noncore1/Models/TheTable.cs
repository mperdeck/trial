using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace noncore1.Models
{
    public class TheTable
    {
        public string Header { get; set; }
        public IEnumerable<Row> Rows { get; set; }

        public Row Row1 { get; set; }
        public Row Row2 { get; set; }
    }
}

