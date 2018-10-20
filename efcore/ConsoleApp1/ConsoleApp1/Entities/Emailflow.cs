using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("emailflow")]
    public partial class Emailflow
    {
        [Key]
        [Column("tooltmpl_id")]
        public int TooltmplId { get; set; }
        [Column("initial_subject")]
        [StringLength(255)]
        public string InitialSubject { get; set; }
        [Column("initial_body")]
        public string InitialBody { get; set; }
        [Column("use_reminder_email")]
        [StringLength(1)]
        public string UseReminderEmail { get; set; }
        [Column("reminder_subject")]
        [StringLength(255)]
        public string ReminderSubject { get; set; }
        [Column("reminder_body")]
        public string ReminderBody { get; set; }
        [Column("use_final_email")]
        [StringLength(1)]
        public string UseFinalEmail { get; set; }
        [Column("final_subject")]
        [StringLength(255)]
        public string FinalSubject { get; set; }
        [Column("final_body")]
        public string FinalBody { get; set; }
        [Column("use_close_email")]
        [StringLength(1)]
        public string UseCloseEmail { get; set; }
        [Column("close_subject")]
        [StringLength(255)]
        public string CloseSubject { get; set; }
        [Column("close_body")]
        public string CloseBody { get; set; }
        [Column("creation_date", TypeName = "datetime")]
        public DateTime? CreationDate { get; set; }
        [Column("initial_is_html_email")]
        [StringLength(1)]
        public string InitialIsHtmlEmail { get; set; }
        [Column("reminder_is_html_email")]
        [StringLength(1)]
        public string ReminderIsHtmlEmail { get; set; }
        [Column("final_is_html_email")]
        [StringLength(1)]
        public string FinalIsHtmlEmail { get; set; }
        [Column("close_is_html_email")]
        [StringLength(1)]
        public string CloseIsHtmlEmail { get; set; }
    }
}
