using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("report")]
    public partial class Report
    {
        [Column("report_id")]
        public int ReportId { get; set; }
        [Column("parent_report_id")]
        public int? ParentReportId { get; set; }
        [Required]
        [Column("crystal_name")]
        [StringLength(100)]
        public string CrystalName { get; set; }
        [Column("report_desc")]
        [StringLength(100)]
        public string ReportDesc { get; set; }
        [Column("database_name")]
        [StringLength(30)]
        public string DatabaseName { get; set; }
        [Required]
        [Column("data_source")]
        [StringLength(50)]
        public string DataSource { get; set; }
        [Required]
        [Column("data_source_type")]
        [StringLength(10)]
        public string DataSourceType { get; set; }
        [Column("viewer_type")]
        [StringLength(1)]
        public string ViewerType { get; set; }
        [Column("run_by")]
        [StringLength(80)]
        public string RunBy { get; set; }
        [Column("run_date", TypeName = "datetime")]
        public DateTime? RunDate { get; set; }
        [Column("reportbatch_id")]
        public int? ReportbatchId { get; set; }
        [Column("archive_file")]
        [StringLength(50)]
        public string ArchiveFile { get; set; }
        [Column("archive_id")]
        public int? ArchiveId { get; set; }
        [Column("report_ext")]
        public Guid? ReportExt { get; set; }
        [StringLength(13)]
        public string RenderingFormat { get; set; }
        public Guid? UnifiedUserId { get; set; }
    }
}
