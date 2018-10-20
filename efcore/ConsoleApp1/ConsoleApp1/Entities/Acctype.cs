using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("acctype")]
    public partial class Acctype
    {
        [Column("acctype_id")]
        public int AcctypeId { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Required]
        [Column("acctype_short")]
        [StringLength(80)]
        public string AcctypeShort { get; set; }
        [Column("acctype_pl")]
        [StringLength(20)]
        public string AcctypePl { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Column("acctype_ext")]
        public Guid? AcctypeExt { get; set; }
        [Column("acctype_order")]
        public short? AcctypeOrder { get; set; }
        [Column("active")]
        [StringLength(1)]
        public string Active { get; set; }
    }
}
