using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("segment")]
    public partial class Segment
    {
        [Column("segment_id")]
        public int SegmentId { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Column("segment_order")]
        public short SegmentOrder { get; set; }
        [Required]
        [Column("segment_name")]
        [StringLength(80)]
        public string SegmentName { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
    }
}
