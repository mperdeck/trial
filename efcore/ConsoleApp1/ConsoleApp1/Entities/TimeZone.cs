using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("TimeZone")]
    public partial class TimeZone
    {
        public int Id { get; set; }
        public int SortOrdinal { get; set; }
        [Required]
        [StringLength(150)]
        public string Country { get; set; }
        [Required]
        [StringLength(150)]
        public string Zone { get; set; }
        [Required]
        [Column("TimeZone")]
        [StringLength(10)]
        public string TimeZone1 { get; set; }
    }
}
