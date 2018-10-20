using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("reporgunit")]
    public partial class Reporgunit
    {
        [Key]
        [Column("orgunit_id")]
        public int OrgunitId { get; set; }
        [Column("org_id")]
        public int? OrgId { get; set; }
        [Column("orgunit_hiddenorder")]
        [StringLength(20)]
        public string OrgunitHiddenorder { get; set; }
        [Column("orgunit_name_1")]
        [StringLength(50)]
        public string OrgunitName1 { get; set; }
        [Column("orgunit_name_2")]
        [StringLength(50)]
        public string OrgunitName2 { get; set; }
        [Column("orgunit_name_3")]
        [StringLength(50)]
        public string OrgunitName3 { get; set; }
        [Column("orgunit_name_4")]
        [StringLength(50)]
        public string OrgunitName4 { get; set; }
    }
}
