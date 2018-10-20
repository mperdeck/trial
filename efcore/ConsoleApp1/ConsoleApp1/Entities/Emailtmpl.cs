using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("emailtmpl")]
    public partial class Emailtmpl
    {
        [Column("emailtmpl_id")]
        public int EmailtmplId { get; set; }
        [Column("tooltmpl_id")]
        public int? TooltmplId { get; set; }
        [Column("emailtmpl_reference")]
        [StringLength(10)]
        public string EmailtmplReference { get; set; }
        [Required]
        [Column("emailtmpl_short")]
        [StringLength(50)]
        public string EmailtmplShort { get; set; }
        [Column("subject")]
        [StringLength(255)]
        public string Subject { get; set; }
        [Column("body")]
        public string Body { get; set; }
        [Column("module")]
        [StringLength(2)]
        public string Module { get; set; }
        [Column("creation_date", TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("emailtmpl_ext")]
        public Guid? EmailtmplExt { get; set; }
        [Column("is_html_email")]
        [StringLength(1)]
        public string IsHtmlEmail { get; set; }
    }
}
