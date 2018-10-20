using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ScopeFee")]
    public partial class ScopeFee
    {
        public int Id { get; set; }
        public int ScopeId { get; set; }
        public int? FunctionId { get; set; }
        public int? ResourceId { get; set; }
        public int? InitiativeId { get; set; }
        public int? DeliverableId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Hours { get; set; }
        [Column(TypeName = "money")]
        public decimal? Fee { get; set; }
        public int? LocalCurrencyId { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseFee { get; set; }
    }
}
