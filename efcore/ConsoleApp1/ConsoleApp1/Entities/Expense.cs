using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("Expense")]
    public partial class Expense
    {
        public int Id { get; set; }
        public int ScopeId { get; set; }
        public int AgencyExpenseId { get; set; }
        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
        public string Description { get; set; }
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
        public int InitiativeId { get; set; }
        public int? DeliverableId { get; set; }
        public int BaseVersionId { get; set; }
        public int VersionNumber { get; set; }
        public int? SourceVersionId { get; set; }
        public int? LocalCurrencyId { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseCost { get; set; }
    }
}
