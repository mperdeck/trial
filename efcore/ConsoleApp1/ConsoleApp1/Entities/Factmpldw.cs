using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("factmpldw")]
    public partial class Factmpldw
    {
        [Column("factmpl_id")]
        public int FactmplId { get; set; }
        [Column("decision_id")]
        public int DecisionId { get; set; }
        [Column("factmpldw_weighting")]
        public double? FactmpldwWeighting { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
    }
}
