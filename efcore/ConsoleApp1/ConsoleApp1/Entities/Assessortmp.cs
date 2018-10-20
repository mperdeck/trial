using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("assessortmp")]
    public partial class Assessortmp
    {
        [Column("account_id")]
        public int AccountId { get; set; }
        [Column("custpers_id")]
        public int CustpersId { get; set; }
        [Column("assessor_type")]
        [StringLength(1)]
        public string AssessorType { get; set; }
    }
}
