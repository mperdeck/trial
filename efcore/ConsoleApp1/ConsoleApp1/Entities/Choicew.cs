using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("choicew")]
    public partial class Choicew
    {
        [Column("choice_id")]
        public int ChoiceId { get; set; }
        [Column("factmpl_id")]
        public int FactmplId { get; set; }
        [Column("choice_weighting")]
        public double? ChoiceWeighting { get; set; }
        [Column("absolute_weighting")]
        public double? AbsoluteWeighting { get; set; }
        [Column("factmpl_weighting")]
        public double? FactmplWeighting { get; set; }
        [Column("factmpl_abs_weighting")]
        public double? FactmplAbsWeighting { get; set; }
        [Column("answered_weighting")]
        public double? AnsweredWeighting { get; set; }
    }
}
