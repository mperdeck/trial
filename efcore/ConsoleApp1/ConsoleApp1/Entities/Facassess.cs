using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("facassess")]
    public partial class Facassess
    {
        [Column("facassess_id")]
        public int FacassessId { get; set; }
        [Column("factmpl_id")]
        public int? FactmplId { get; set; }
        [Column("assesstype_id")]
        public int? AssesstypeId { get; set; }
        [Column("facassess_ext")]
        public Guid? FacassessExt { get; set; }
    }
}
