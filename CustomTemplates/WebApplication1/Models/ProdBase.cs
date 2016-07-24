using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ProdBase
    {
        public string base1 { get; set; }
        public string base2 { get; set; }

        [Display(Name ="The 1 prod!")]
        public Prod1 Prod1 { get; set; }
        //public prod2 Prod2 { get; set; }

        [UIHint("Children")]
        public List<Child> Children { get; set; }

        public ProdBase()
        {
            Children = new List<Child>();
            Prod1 = new Prod1();
        }
    }
}