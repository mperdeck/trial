using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ansval")]
    public partial class Ansval
    {
        [Column("decision_id")]
        public int DecisionId { get; set; }
        [Column("custpers_id")]
        public int CustpersId { get; set; }
        [Column("quesmst_id")]
        public int QuesmstId { get; set; }
        [Column("ansval_value")]
        [StringLength(4000)]
        public string AnsvalValue { get; set; }
        [Column("ansval_count")]
        public short? AnsvalCount { get; set; }
    }
}
