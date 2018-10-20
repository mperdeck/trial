using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("repsegment")]
    public partial class Repsegment
    {
        [Key]
        [Column("segment_id")]
        public int SegmentId { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Required]
        [Column("segment_name")]
        [StringLength(80)]
        public string SegmentName { get; set; }
    }
}
