using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("status")]
    public partial class Status
    {
        [Column("status_id")]
        public int StatusId { get; set; }
        [Column("org_id")]
        public int OrgId { get; set; }
        [Column("status_order")]
        public short StatusOrder { get; set; }
        [Required]
        [Column("status_short")]
        [StringLength(80)]
        public string StatusShort { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
    }
}
