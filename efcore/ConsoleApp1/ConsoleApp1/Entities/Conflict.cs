using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("conflict")]
    public partial class Conflict
    {
        [Column("conflict_id")]
        public int ConflictId { get; set; }
        [Column("org_id")]
        public int OrgId { get; set; }
        [Column("conflict_order")]
        public short ConflictOrder { get; set; }
        [Required]
        [Column("conflict_short")]
        [StringLength(80)]
        public string ConflictShort { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
    }
}
