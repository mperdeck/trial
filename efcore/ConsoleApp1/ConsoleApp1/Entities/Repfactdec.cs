using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("repfactdec")]
    public partial class Repfactdec
    {
        [Column("repfactdec_id")]
        public int RepfactdecId { get; set; }
        [Column("org_id")]
        public int OrgId { get; set; }
        [Column("period_id")]
        public int PeriodId { get; set; }
        [Column("prev_period_id")]
        public int? PrevPeriodId { get; set; }
        [Column("dectmpl_id")]
        public int? DectmplId { get; set; }
        [Column("orgunit_id")]
        public int? OrgunitId { get; set; }
        [Column("custorgunit_id")]
        public int? CustorgunitId { get; set; }
        [Column("geography_id")]
        public int? GeographyId { get; set; }
        [Column("acctype_id")]
        public int? AcctypeId { get; set; }
        [Column("subacctype_id")]
        public int? SubacctypeId { get; set; }
        [Column("account_id")]
        public int AccountId { get; set; }
        [Column("account_short")]
        [StringLength(50)]
        public string AccountShort { get; set; }
        [Column("account_value")]
        public int? AccountValue { get; set; }
        [Column("custorg_id")]
        public int? CustorgId { get; set; }
        [Column("custorg_name")]
        [StringLength(50)]
        public string CustorgName { get; set; }
        [Column("int_ext")]
        [StringLength(1)]
        public string IntExt { get; set; }
        [Column("decision_weighting")]
        public double? DecisionWeighting { get; set; }
        [Column("prev_decision_weighting")]
        public double? PrevDecisionWeighting { get; set; }
        [Column("xaxis_weighting")]
        public double? XaxisWeighting { get; set; }
        [Column("yaxis_weighting")]
        public double? YaxisWeighting { get; set; }
        [Column("no_promoters")]
        public int? NoPromoters { get; set; }
        [Column("no_neutrals")]
        public int? NoNeutrals { get; set; }
        [Column("no_detractors")]
        public int? NoDetractors { get; set; }
        [Column("section_weighting_1")]
        public double? SectionWeighting1 { get; set; }
        [Column("section_weighting_2")]
        public double? SectionWeighting2 { get; set; }
        [Column("section_weighting_3")]
        public double? SectionWeighting3 { get; set; }
        [Column("section_weighting_4")]
        public double? SectionWeighting4 { get; set; }
        [Column("section_weighting_5")]
        public double? SectionWeighting5 { get; set; }
        [Column("section_weighting_6")]
        public double? SectionWeighting6 { get; set; }
        [Column("section_weighting_7")]
        public double? SectionWeighting7 { get; set; }
        [Column("section_weighting_8")]
        public double? SectionWeighting8 { get; set; }
        [Column("answered_weighting")]
        public double? AnsweredWeighting { get; set; }
        [Column("hard_percent")]
        public double? HardPercent { get; set; }
        [Column("inter_percent")]
        public double? InterPercent { get; set; }
        [Column("soft_percent")]
        public double? SoftPercent { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Column("segment_id")]
        public int? SegmentId { get; set; }
    }
}
