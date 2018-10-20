using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("repcustorgunit")]
    public partial class Repcustorgunit
    {
        [Key]
        [Column("custorgunit_id")]
        public int CustorgunitId { get; set; }
        [Column("org_id")]
        public int? OrgId { get; set; }
        [Column("custorgunit_hiddenorder")]
        [StringLength(20)]
        public string CustorgunitHiddenorder { get; set; }
        [Column("custorgunit_name_1")]
        [StringLength(50)]
        public string CustorgunitName1 { get; set; }
        [Column("custorgunit_name_2")]
        [StringLength(50)]
        public string CustorgunitName2 { get; set; }
        [Column("custorgunit_name_3")]
        [StringLength(50)]
        public string CustorgunitName3 { get; set; }
    }
}
