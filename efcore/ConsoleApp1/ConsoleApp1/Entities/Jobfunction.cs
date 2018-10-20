using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("jobfunction")]
    public partial class Jobfunction
    {
        [Column("jobfunction_id")]
        public int JobfunctionId { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Column("jobfunction_order")]
        public short JobfunctionOrder { get; set; }
        [Required]
        [Column("jobfunction_short")]
        [StringLength(80)]
        public string JobfunctionShort { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Required]
        [Column("active")]
        [StringLength(1)]
        public string Active { get; set; }
        [Column("jobfunction_ext")]
        public Guid JobfunctionExt { get; set; }
    }
}
