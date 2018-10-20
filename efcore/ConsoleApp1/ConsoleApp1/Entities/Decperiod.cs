using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("decperiod")]
    public partial class Decperiod
    {
        [Column("decperiod_id")]
        public int DecperiodId { get; set; }
        [Column("decision_id")]
        public int DecisionId { get; set; }
        [Column("period_id")]
        public int PeriodId { get; set; }
        [Column("submitted")]
        [StringLength(1)]
        public string Submitted { get; set; }
        [Column("complete")]
        [StringLength(1)]
        public string Complete { get; set; }
        [Column("last_email_date", TypeName = "datetime")]
        public DateTime? LastEmailDate { get; set; }
        [Column("decperiod_ext")]
        public Guid? DecperiodExt { get; set; }
    }
}
