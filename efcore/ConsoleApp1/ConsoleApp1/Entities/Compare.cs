using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("compare")]
    public partial class Compare
    {
        [Column("compare_id")]
        [StringLength(2)]
        public string CompareId { get; set; }
        [Required]
        [Column("compare_short")]
        [StringLength(30)]
        public string CompareShort { get; set; }
        [Column("compare_order")]
        public short CompareOrder { get; set; }
    }
}
