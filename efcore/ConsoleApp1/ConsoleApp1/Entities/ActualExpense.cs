using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ActualExpense")]
    public partial class ActualExpense
    {
        public int Id { get; set; }
        public int ActualId { get; set; }
        public int ExpenseId { get; set; }
        public int? LocalCurrencyId { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseOutOfPocket { get; set; }
        [Column(TypeName = "money")]
        public decimal? OutOfPocket { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDeleted { get; set; }
        [Required]
        [StringLength(150)]
        public string CreatedBy { get; set; }
        [StringLength(150)]
        public string LastUpdatedBy { get; set; }
        [StringLength(150)]
        public string DeletedBy { get; set; }
    }
}
