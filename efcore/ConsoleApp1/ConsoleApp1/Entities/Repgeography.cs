using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("repgeography")]
    public partial class Repgeography
    {
        [Key]
        [Column("geography_id")]
        public int GeographyId { get; set; }
        [Column("org_id")]
        public int? OrgId { get; set; }
        [Column("geography_hiddenorder")]
        [StringLength(20)]
        public string GeographyHiddenorder { get; set; }
        [Column("geography_name_1")]
        [StringLength(50)]
        public string GeographyName1 { get; set; }
        [Column("geography_name_2")]
        [StringLength(50)]
        public string GeographyName2 { get; set; }
        [Column("geography_name_3")]
        [StringLength(50)]
        public string GeographyName3 { get; set; }
    }
}
