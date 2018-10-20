using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("BuyoutMediaMaterial")]
    public partial class BuyoutMediaMaterial
    {
        public int BuyoutId { get; set; }
        public int MediaMaterialId { get; set; }
    }
}
