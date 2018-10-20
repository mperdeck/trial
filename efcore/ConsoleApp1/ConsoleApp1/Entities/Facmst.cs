using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("facmst")]
    public partial class Facmst
    {
        [Column("facmst_id")]
        public int FacmstId { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Required]
        [Column("facmst_short")]
        [StringLength(50)]
        public string FacmstShort { get; set; }
        [Column("facmst_desc")]
        [StringLength(1000)]
        public string FacmstDesc { get; set; }
        [Column("evidence_desc")]
        [StringLength(2000)]
        public string EvidenceDesc { get; set; }
        [Column("creation_date", TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Column("facmst_ext")]
        public Guid? FacmstExt { get; set; }
    }
}
