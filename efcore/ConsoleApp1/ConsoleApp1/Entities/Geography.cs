using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("geography")]
    public partial class Geography
    {
        [Column("geography_id")]
        public int GeographyId { get; set; }
        [Column("org_id")]
        public int OrgId { get; set; }
        [Column("geography_order")]
        public short GeographyOrder { get; set; }
        [Column("geography_level")]
        public short GeographyLevel { get; set; }
        [Column("geography_levelorder")]
        [StringLength(10)]
        public string GeographyLevelorder { get; set; }
        [Column("geography_hiddenorder")]
        [StringLength(10)]
        public string GeographyHiddenorder { get; set; }
        [Required]
        [Column("geography_name")]
        [StringLength(50)]
        public string GeographyName { get; set; }
        [Column("parent_geography_id")]
        public int ParentGeographyId { get; set; }
        [Column("priority")]
        [StringLength(1)]
        public string Priority { get; set; }
        [Column("active")]
        [StringLength(1)]
        public string Active { get; set; }
        [Column("clone_geography_id")]
        public int? CloneGeographyId { get; set; }
        [Column("geography_ext")]
        public Guid? GeographyExt { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }






    }
}
