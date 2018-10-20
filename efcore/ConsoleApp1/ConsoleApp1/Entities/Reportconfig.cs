using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("reportconfig")]
    public partial class Reportconfig
    {
        [Key]
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Column("incl_assessment_in_consolidation")]
        [StringLength(1)]
        public string InclAssessmentInConsolidation { get; set; }
        [Column("incl_gap_in_consolidation")]
        [StringLength(1)]
        public string InclGapInConsolidation { get; set; }
        [Column("incl_benchmark_in_consolidation")]
        [StringLength(1)]
        public string InclBenchmarkInConsolidation { get; set; }
        [Column("incl_trend_in_consolidation")]
        [StringLength(1)]
        public string InclTrendInConsolidation { get; set; }
        [Column("incl_individualcrosstab_in_consolidation")]
        [StringLength(1)]
        public string InclIndividualcrosstabInConsolidation { get; set; }
        [Column("incl_locationcrosstab_in_consolidation")]
        [StringLength(1)]
        public string InclLocationcrosstabInConsolidation { get; set; }
        [Column("incl_jobfunctioncrosstab_in_consolidation")]
        [StringLength(1)]
        public string InclJobfunctioncrosstabInConsolidation { get; set; }
        [Column("incl_evaluatorgroupcrosstab_in_consolidation")]
        [StringLength(1)]
        public string InclEvaluatorgroupcrosstabInConsolidation { get; set; }
        [Column("incl_comments_in_consolidation")]
        [StringLength(1)]
        public string InclCommentsInConsolidation { get; set; }
        [Column("incl_assessment_in_execsummary")]
        [StringLength(1)]
        public string InclAssessmentInExecsummary { get; set; }
        [Column("incl_gap_in_execsummary")]
        [StringLength(1)]
        public string InclGapInExecsummary { get; set; }
        [Column("incl_benchmark_in_execsummary")]
        [StringLength(1)]
        public string InclBenchmarkInExecsummary { get; set; }
        [Column("incl_trend_in_execsummary")]
        [StringLength(1)]
        public string InclTrendInExecsummary { get; set; }
        [Column("incl_individualcrosstab_in_execsummary")]
        [StringLength(1)]
        public string InclIndividualcrosstabInExecsummary { get; set; }
        [Column("incl_locationcrosstab_in_execsummary")]
        [StringLength(1)]
        public string InclLocationcrosstabInExecsummary { get; set; }
        [Column("incl_jobfunctioncrosstab_in_execsummary")]
        [StringLength(1)]
        public string InclJobfunctioncrosstabInExecsummary { get; set; }
        [Column("incl_evaluatorgroupcrosstab_in_execsummary")]
        [StringLength(1)]
        public string InclEvaluatorgroupcrosstabInExecsummary { get; set; }
        [Column("incl_comments_in_execsummary")]
        [StringLength(1)]
        public string InclCommentsInExecsummary { get; set; }
        [Column("creation_date", TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
    }
}
