using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("assessor")]
    public partial class Assessor
    {
        [Column("assessor_id")]
        public int AssessorId { get; set; }
        [Column("assessor_ext")]
        public Guid AssessorExt { get; set; }
        [Column("account_id")]
        public int AccountId { get; set; }
        [Column("custpers_id")]
        public int CustpersId { get; set; }
        [Required]
        [Column("assessor_type")]
        [StringLength(1)]
        public string AssessorType { get; set; }
        [Column("decision_owner")]
        [StringLength(1)]
        public string DecisionOwner { get; set; }
        [Column("signatory")]
        [StringLength(1)]
        public string Signatory { get; set; }
        [Column("individual_evaluator")]
        [StringLength(1)]
        public string IndividualEvaluator { get; set; }
        [Column("view_reports")]
        [StringLength(1)]
        public string ViewReports { get; set; }
        [Column("read_only_owner")]
        [StringLength(1)]
        public string ReadOnlyOwner { get; set; }
        [Column("assessor_weighting")]
        public double? AssessorWeighting { get; set; }
        [Column("comment_decline")]
        [StringLength(500)]
        public string CommentDecline { get; set; }
        [Column("evaluatorgroup_id")]
        public int? EvaluatorgroupId { get; set; }
    }
}
