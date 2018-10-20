using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("facmstm")]
    public partial class Facmstm
    {
        [Column("facmst_id")]
        public int FacmstId { get; set; }
        [Column("measure_order")]
        public int MeasureOrder { get; set; }
        [Column("measure_short")]
        [StringLength(1000)]
        public string MeasureShort { get; set; }
        [Column("measure_value")]
        public short? MeasureValue { get; set; }
    }
}
