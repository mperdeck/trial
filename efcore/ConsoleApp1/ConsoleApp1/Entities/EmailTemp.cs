using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("email_temp")]
    public partial class EmailTemp
    {
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Column("custpers_id")]
        public int CustpersId { get; set; }
        [Column("from_name")]
        [StringLength(100)]
        public string FromName { get; set; }
        [Column("from_address")]
        [StringLength(100)]
        public string FromAddress { get; set; }
        [Column("to_name")]
        [StringLength(100)]
        public string ToName { get; set; }
        [Column("to_first_name")]
        [StringLength(100)]
        public string ToFirstName { get; set; }
        [Column("to_address")]
        [StringLength(100)]
        public string ToAddress { get; set; }
        [Column("login_details")]
        [StringLength(500)]
        public string LoginDetails { get; set; }
        [Column("account_details")]
        public string AccountDetails { get; set; }
        [Column("email_subject")]
        [StringLength(255)]
        public string EmailSubject { get; set; }
        [Column("email_body")]
        public string EmailBody { get; set; }
        [Required]
        [Column("last_email_status")]
        [StringLength(1)]
        public string LastEmailStatus { get; set; }
        [Required]
        [Column("this_email_status")]
        [StringLength(1)]
        public string ThisEmailStatus { get; set; }
        [Column("is_html_email")]
        [StringLength(1)]
        public string IsHtmlEmail { get; set; }
    }
}
