using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("choicer")]
    public partial class Choicer
    {
        [Column("factmpl_id")]
        public int FactmplId { get; set; }
        [Column("choice_id")]
        public int ChoiceId { get; set; }
        [Column("choice_relative")]
        public short ChoiceRelative { get; set; }
        [Column("aggregate_weighting")]
        public double? AggregateWeighting { get; set; }
        [Column("comment")]
        [StringLength(2000)]
        public string Comment { get; set; }
        [Column("choicer_ext")]
        public Guid? ChoicerExt { get; set; }
        [Column("prev_aggregate_weighting")]
        public double? PrevAggregateWeighting { get; set; }
    }
}
