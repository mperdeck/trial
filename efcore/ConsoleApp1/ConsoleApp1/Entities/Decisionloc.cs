using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("decisionloc")]
    public partial class Decisionloc
    {
        [Column("decision_id")]
        public int DecisionId { get; set; }
        [Column("location_id")]
        public int LocationId { get; set; }
        [Column("location_weighting")]
        public double? LocationWeighting { get; set; }
        [Column("no_assessors")]
        public int? NoAssessors { get; set; }
    }
}
