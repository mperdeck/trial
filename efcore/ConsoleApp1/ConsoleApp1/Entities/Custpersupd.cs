using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("custpersupd")]
    public partial class Custpersupd
    {
        [Column("custpersupd_id")]
        public int CustpersupdId { get; set; }
        [Column("org_id")]
        public int OrgId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(15)]
        public string FirstName { get; set; }
        [Required]
        [Column("surname")]
        [StringLength(20)]
        public string Surname { get; set; }
        [Required]
        [Column("email")]
        [StringLength(80)]
        public string Email { get; set; }
        [Column("batch_id")]
        public int BatchId { get; set; }
        [Column("upload_date", TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
    }
}
