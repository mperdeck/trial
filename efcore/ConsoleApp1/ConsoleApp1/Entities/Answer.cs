using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("answer")]
    public partial class Answer
    {
        [Column("decision_id")]
        public int DecisionId { get; set; }
        [Column("custpers_id")]
        public int CustpersId { get; set; }
        [Column("ansmst_id")]
        public int AnsmstId { get; set; }
        [Required]
        [Column("answer_flag")]
        [StringLength(1)]
        public string AnswerFlag { get; set; }
        [Column("answer_count")]
        public short? AnswerCount { get; set; }
    }
}
