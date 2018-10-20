using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("location")]
    public partial class Location
    {
        [Column("location_id")]
        public int LocationId { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Column("location_order")]
        public short LocationOrder { get; set; }
        [Required]
        [Column("location_short")]
        [StringLength(80)]
        public string LocationShort { get; set; }
        [Column("geography_id")]
        public int? GeographyId { get; set; }
        [Required]
        [Column("active")]
        [StringLength(1)]
        public string Active { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Column("location_ext")]
        public Guid LocationExt { get; set; }
    }
}
