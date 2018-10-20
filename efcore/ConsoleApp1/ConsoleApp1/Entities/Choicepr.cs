using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("choicepr")]
    public partial class Choicepr
    {
        [Column("custpers_id")]
        public int CustpersId { get; set; }
        [Column("factmpl_id")]
        public int FactmplId { get; set; }
        [Column("choice_id")]
        public int ChoiceId { get; set; }
        [Column("choicepr_ext")]
        public Guid? ChoiceprExt { get; set; }
        [Column("choice_relative")]
        public short ChoiceRelative { get; set; }
        [Column("comment")]
        [StringLength(2000)]
        public string Comment { get; set; }
        [Column("importance_relative")]
        public short? ImportanceRelative { get; set; }
    }
}
