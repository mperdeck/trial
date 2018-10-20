using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("evaluatorgroup")]
    public partial class Evaluatorgroup
    {
        [Column("evaluatorgroup_id")]
        public int EvaluatorgroupId { get; set; }
        [Column("evaluatorgroup_ext")]
        public Guid EvaluatorgroupExt { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Column("evaluatorgroup_order")]
        public short EvaluatorgroupOrder { get; set; }
        [Required]
        [Column("evaluatorgroup_short")]
        [StringLength(80)]
        public string EvaluatorgroupShort { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Required]
        [Column("active")]
        [StringLength(1)]
        public string Active { get; set; }
    }
}
