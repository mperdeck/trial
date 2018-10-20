using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
    public partial class Country
    {
        public int Id { get; set; }
        [Column("ISO2")]
        [StringLength(2)]
        public string Iso2 { get; set; }
        [Required]
        [StringLength(80)]
        public string Name { get; set; }
    }
}
