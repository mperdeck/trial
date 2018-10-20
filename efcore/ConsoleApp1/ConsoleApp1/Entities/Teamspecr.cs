using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("teamspecr")]
    public partial class Teamspecr
    {
        [Column("team_id")]
        public int TeamId { get; set; }
        [Column("specialty_id")]
        public int SpecialtyId { get; set; }
        [Column("comment")]
        [StringLength(2000)]
        public string Comment { get; set; }
    }
}
