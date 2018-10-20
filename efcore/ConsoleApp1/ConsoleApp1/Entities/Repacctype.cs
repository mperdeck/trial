using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("repacctype")]
    public partial class Repacctype
    {
        [Key]
        [Column("acctype_id")]
        public int AcctypeId { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Required]
        [Column("acctype_short")]
        [StringLength(80)]
        public string AcctypeShort { get; set; }
    }
}
