using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ActualFee")]
    public partial class ActualFee
    {
        public int Id { get; set; }
        public int ActualId { get; set; }
        public int? FunctionId { get; set; }
        public int? ResourceId { get; set; }
        public int? InitiativeId { get; set; }
        public int? DeliverableId { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Hours { get; set; }
        [Column(TypeName = "money")]
        public decimal? Fee { get; set; }
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
        public int? LocalCurrencyId { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseFee { get; set; }
    }
}
