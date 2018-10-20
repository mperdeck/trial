using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("factscale")]
    public partial class Factscale
    {
        [Column("factscale_id")]
        public int FactscaleId { get; set; }
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Required]
        [Column("frequency")]
        [StringLength(1)]
        public string Frequency { get; set; }
        [Column("period_count")]
        public short? PeriodCount { get; set; }
        [Column("factscale_ext")]
        public Guid? FactscaleExt { get; set; }
    }
}
