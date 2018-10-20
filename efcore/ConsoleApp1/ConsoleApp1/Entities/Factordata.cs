using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("factordata")]
    public partial class Factordata
    {
        [Column("factordata_id")]
        public int FactordataId { get; set; }
        [Column("decperiod_id")]
        public int DecperiodId { get; set; }
        [Column("factor_id")]
        public int FactorId { get; set; }
        [Column("factor_value")]
        public int FactorValue { get; set; }
        [Column("comment")]
        [StringLength(2000)]
        public string Comment { get; set; }
        [Column("factordata_ext")]
        public Guid FactordataExt { get; set; }
    }
}
