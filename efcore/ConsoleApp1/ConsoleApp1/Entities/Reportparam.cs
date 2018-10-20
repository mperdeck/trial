using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("reportparam")]
    public partial class Reportparam
    {
        [Column("reportparam_id")]
        public int ReportparamId { get; set; }
        [Column("report_id")]
        public int ReportId { get; set; }
        [Column("reportparam_order")]
        public int ReportparamOrder { get; set; }
        [Required]
        [Column("datatype")]
        [StringLength(10)]
        public string Datatype { get; set; }
        [Column("datasize")]
        public int Datasize { get; set; }
        [Required]
        [Column("dataname")]
        [StringLength(50)]
        public string Dataname { get; set; }
        [Column("datavalue")]
        [StringLength(1000)]
        public string Datavalue { get; set; }
    }
}
