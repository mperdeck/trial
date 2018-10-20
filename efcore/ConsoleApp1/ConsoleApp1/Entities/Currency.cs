using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("Currency")]
    public partial class Currency
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        [Required]
        [StringLength(100)]
        public string Country { get; set; }
        [Required]
        [StringLength(10)]
        public string Code { get; set; }
        [Required]
        [StringLength(5)]
        public string Symbol { get; set; }
        public int SortOrdinal { get; set; }
    }
}
