using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("custpersaccassess")]
    public partial class Custpersaccassess
    {
        [Column("custpers_id")]
        public int CustpersId { get; set; }
        [Column("account_id")]
        public int AccountId { get; set; }
        [Column("assesstype_id")]
        public int AssesstypeId { get; set; }
    }
}
