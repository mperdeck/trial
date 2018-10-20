using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("quesmst")]
    public partial class Quesmst
    {
        [Column("quesmst_id")]
        public int QuesmstId { get; set; }
        [Column("dectmpl_id")]
        public int DectmplId { get; set; }
        [Column("quesmst_order")]
        public short QuesmstOrder { get; set; }
        [Required]
        [Column("quesmst_short")]
        [StringLength(80)]
        public string QuesmstShort { get; set; }
        [Column("quesmst_desc")]
        [StringLength(2000)]
        public string QuesmstDesc { get; set; }
        [Column("header_desc")]
        [StringLength(2000)]
        public string HeaderDesc { get; set; }
        [Required]
        [Column("input_type")]
        [StringLength(1)]
        public string InputType { get; set; }
        [Column("required_field")]
        [StringLength(1)]
        public string RequiredField { get; set; }
        [Column("display_across")]
        [StringLength(1)]
        public string DisplayAcross { get; set; }
        [Column("gap_before")]
        [StringLength(1)]
        public string GapBefore { get; set; }
        [Column("gap_after")]
        [StringLength(1)]
        public string GapAfter { get; set; }
        [Column("clone_quesmst_id")]
        public int? CloneQuesmstId { get; set; }
        [Column("creation_date", TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
    }
}
