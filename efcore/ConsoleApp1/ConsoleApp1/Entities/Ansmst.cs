using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ansmst")]
    public partial class Ansmst
    {
        [Column("ansmst_id")]
        public int AnsmstId { get; set; }
        [Column("quesmst_id")]
        public int QuesmstId { get; set; }
        [Column("ansmst_order")]
        public short AnsmstOrder { get; set; }
        [Required]
        [Column("ansmst_short")]
        [StringLength(80)]
        public string AnsmstShort { get; set; }
        [Column("creation_date", TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
    }
}
