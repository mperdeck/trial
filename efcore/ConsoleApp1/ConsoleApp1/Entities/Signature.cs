using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("signature")]
    public partial class Signature
    {
        [Column("decision_id")]
        public int DecisionId { get; set; }
        [Column("custpers_id")]
        public int CustpersId { get; set; }
        [Required]
        [Column("signature_type")]
        [StringLength(1)]
        public string SignatureType { get; set; }
        [Column("complete")]
        [StringLength(1)]
        public string Complete { get; set; }
        [Column("complete_date", TypeName = "datetime")]
        public DateTime? CompleteDate { get; set; }
    }
}
