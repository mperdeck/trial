using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("assesstype")]
    public partial class Assesstype
    {
        [Column("assesstype_id")]
        public int AssesstypeId { get; set; }
        [Column("assesstype_ext")]
        public Guid AssesstypeExt { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Column("assesstype_order")]
        public short AssesstypeOrder { get; set; }
        [Required]
        [Column("assesstype_short")]
        [StringLength(80)]
        public string AssesstypeShort { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
    }
}
