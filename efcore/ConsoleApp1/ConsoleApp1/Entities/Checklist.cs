using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("checklist")]
    public partial class Checklist
    {
        [Column("checklist_id")]
        public int ChecklistId { get; set; }
        [Column("checkmst_id")]
        public int CheckmstId { get; set; }
        [Column("factordata_id")]
        public int FactordataId { get; set; }
        [Column("checked")]
        [StringLength(1)]
        public string Checked { get; set; }
        [Column("comment")]
        [StringLength(2000)]
        public string Comment { get; set; }
        [Column("checklist_ext")]
        public Guid ChecklistExt { get; set; }
    }
}
