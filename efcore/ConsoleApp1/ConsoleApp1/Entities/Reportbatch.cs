using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("reportbatch")]
    public partial class Reportbatch
    {
        [Column("reportbatch_id")]
        public int ReportbatchId { get; set; }
        [Column("create_date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        public Guid? UnifiedUserId { get; set; }
        [Column("reportbatch_ext")]
        public Guid? ReportbatchExt { get; set; }
        [StringLength(2)]
        public string StatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }
    }
}
