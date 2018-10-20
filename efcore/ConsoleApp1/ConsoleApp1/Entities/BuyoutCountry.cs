using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("BuyoutCountry")]
    public partial class BuyoutCountry
    {
        public int BuyoutId { get; set; }
        public int CountryId { get; set; }
    }
}
