using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("Review")]
    public partial class Review
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int TemplateId { get; set; }
        public int PeriodId { get; set; }
        public int AccountId { get; set; }
        public int? DownloadId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(20)]
        public string ProjectCode { get; set; }
        [StringLength(1)]
        public string Type { get; set; }
        public bool? CurrentReview { get; set; }
        public bool? IsGlobalReview { get; set; }
        public int? StartPeriodId { get; set; }
        public int? EndPeriodId { get; set; }
        [StringLength(1)]
        public string Frequency { get; set; }
        public bool? CollectFromSupplier { get; set; }
        public bool? IsSelfAssessment { get; set; }
        public bool? ClientHasMultipleEvaluators { get; set; }
        public bool? SupplierHasMultipleEvaluators { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewDate { get; set; }
        public bool IsComplete { get; set; }
        public bool? OwnerQuantmeasureOverwrite { get; set; }
        public double? HardMeasureTotal { get; set; }
        public bool? UseHardMeasure { get; set; }
        public double? IntermediateMeasureTotal { get; set; }
        public bool? UseIntermediateMeasure { get; set; }
        [StringLength(2)]
        public string Weighting { get; set; }
        public double? HardWeighting { get; set; }
        public double? IntermediateWeighting { get; set; }
        public double? SoftWeighting { get; set; }
        public double? FinalWeighting { get; set; }
        public double? OriginalFinalWeighting { get; set; }
        public double? AnsweredWeighting { get; set; }
        public double? HardPercent { get; set; }
        public double? IntermediatePercent { get; set; }
        public double? SoftPercent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompleteDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EmailDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinalCompleteDate { get; set; }
        public int? SubmitWeeks { get; set; }
        public int? NumberOfPromoters { get; set; }
        public int? NumberOfDetractors { get; set; }
        public int? NumberOfNeutrals { get; set; }
    }
}
