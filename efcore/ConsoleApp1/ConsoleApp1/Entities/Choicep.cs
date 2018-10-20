using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("choicep")]
    public partial class Choicep
    {
        [Column("custpers_id")]
        public int CustpersId { get; set; }
        [Column("choice_id")]
        public int ChoiceId { get; set; }
        [Column("choicep_ext")]
        public Guid? ChoicepExt { get; set; }
        [Column("decision_weighting")]
        public double? DecisionWeighting { get; set; }
        [Column("answered_weighting")]
        public double? AnsweredWeighting { get; set; }
        [Column("xaxis_weighting")]
        public double? XaxisWeighting { get; set; }
        [Column("yaxis_weighting")]
        public double? YaxisWeighting { get; set; }
        [Column("comment_strong")]
        [StringLength(2000)]
        public string CommentStrong { get; set; }
        [Column("comment_weak")]
        [StringLength(2000)]
        public string CommentWeak { get; set; }
        [Column("comment_overall")]
        [StringLength(2000)]
        public string CommentOverall { get; set; }
        [Column("comment_1")]
        [StringLength(2000)]
        public string Comment1 { get; set; }
        [Column("comment_2")]
        [StringLength(2000)]
        public string Comment2 { get; set; }
        [Column("promoter")]
        public short? Promoter { get; set; }
        [Column("complete")]
        [StringLength(1)]
        public string Complete { get; set; }
        [Column("location_id")]
        public int? LocationId { get; set; }
        [Column("jobfunction_id")]
        public int? JobfunctionId { get; set; }
        [Column("evaluatorgroup_id")]
        public int? EvaluatorgroupId { get; set; }
        [Column("assessor_weighting")]
        public double? AssessorWeighting { get; set; }
    }
}
