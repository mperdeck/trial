using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProdBase
    {
        public string base1 { get; set; }
        public string base2 { get; set; }

        public prod1 Prod1 { get; set; }
        public prod2 Prod2 { get; set; }

        public List<Child> Children { get; private set; }

        public ProdBase()
        {
            Children = new List<Models.Child>();
        }
    }
}