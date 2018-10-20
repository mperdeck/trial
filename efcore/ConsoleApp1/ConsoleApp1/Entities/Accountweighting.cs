using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("accountweighting")]
    public partial class Accountweighting
    {
        [Column("account_id")]
        public int AccountId { get; set; }
        [Column("period_id")]
        public int PeriodId { get; set; }
        [Column("account_value")]
        public int AccountValue { get; set; }
    }
}
