using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("checkmst")]
    public partial class Checkmst
    {
        [Column("checkmst_id")]
        public int CheckmstId { get; set; }
        [Column("factor_id")]
        public int FactorId { get; set; }
        [Column("checkmst_order")]
        public short CheckmstOrder { get; set; }
        [Required]
        [Column("checkmst_name")]
        [StringLength(500)]
        public string CheckmstName { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Column("checkmst_ext")]
        public Guid CheckmstExt { get; set; }
    }
}
