using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("factscalem")]
    public partial class Factscalem
    {
        [Column("factscale_id")]
        public int FactscaleId { get; set; }
        [Column("measure_order")]
        public short MeasureOrder { get; set; }
        [Column("measure_upper")]
        public double? MeasureUpper { get; set; }
        [Column("measure_lower")]
        public double? MeasureLower { get; set; }
    }
}
