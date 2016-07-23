using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Product: ProdBase
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int CatalogId { get; set; }

        public Product(): base()
        {
        }
    }
}


