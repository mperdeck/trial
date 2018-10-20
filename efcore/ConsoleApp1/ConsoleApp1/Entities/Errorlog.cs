using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("errorlog")]
    public partial class Errorlog
    {
        [Column("errorlog_id")]
        public int ErrorlogId { get; set; }
        [Required]
        [Column("application_id")]
        [StringLength(2)]
        public string ApplicationId { get; set; }
        [Column("person_id")]
        public int? PersonId { get; set; }
        [Column("custpers_id")]
        public int? CustpersId { get; set; }
        [Required]
        [Column("page_name")]
        [StringLength(50)]
        public string PageName { get; set; }
        [Column("component")]
        [StringLength(50)]
        public string Component { get; set; }
        [Column("error_id")]
        public int? ErrorId { get; set; }
        [Required]
        [Column("error_desc")]
        [StringLength(1000)]
        public string ErrorDesc { get; set; }
        [Column("error_status")]
        [StringLength(50)]
        public string ErrorStatus { get; set; }
        [Column("error_field")]
        [StringLength(50)]
        public string ErrorField { get; set; }
        [Column("errorlog_date", TypeName = "datetime")]
        public DateTime ErrorlogDate { get; set; }
    }
}
