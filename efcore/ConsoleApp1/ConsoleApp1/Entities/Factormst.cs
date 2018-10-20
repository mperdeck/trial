using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("factormst")]
    public partial class Factormst
    {
        [Column("factormst_id")]
        public int FactormstId { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Required]
        [Column("factormst_short")]
        [StringLength(50)]
        public string FactormstShort { get; set; }
        [Column("factormst_desc")]
        [StringLength(1000)]
        public string FactormstDesc { get; set; }
        [Column("factormst_type")]
        [StringLength(1)]
        public string FactormstType { get; set; }
        [Column("factormst_unit")]
        [StringLength(20)]
        public string FactormstUnit { get; set; }
        [Column("use_quant")]
        [StringLength(1)]
        public string UseQuant { get; set; }
        [Column("creation_date", TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Column("factormst_ext")]
        public Guid? FactormstExt { get; set; }
    }
}
