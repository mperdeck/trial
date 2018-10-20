using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("reportcolumn")]
    public partial class Reportcolumn
    {
        [Column("reportcolumn_id")]
        public int ReportcolumnId { get; set; }
        [Column("report_id")]
        public int ReportId { get; set; }
        [Column("reportcolumn_order")]
        public int ReportcolumnOrder { get; set; }
        [Required]
        [Column("reportcolumn_name")]
        [StringLength(50)]
        public string ReportcolumnName { get; set; }
        [Required]
        [Column("reportcolumn_alias")]
        [StringLength(50)]
        public string ReportcolumnAlias { get; set; }
    }
}
