using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ScopeItem")]
    public partial class ScopeItem
    {
        public int Id { get; set; }
        public Guid ExtId { get; set; }
        public int BaseVersionId { get; set; }
        public int VersionNumber { get; set; }
        public int? SourceVersionId { get; set; }
        public int ScopeId { get; set; }
        public int? ScopeItemGroupId { get; set; }
        public int ItemTypeId { get; set; }
        public int SortOrdinal { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public int? LocalCurrencyId { get; set; }
        public bool? IsMultiYearItem { get; set; }
        public int? StartBudgetPeriodId { get; set; }
        public int? NumberOfYears { get; set; }
        [Column(TypeName = "money")]
        public decimal? EstimatedMultiYearCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseEstimatedMultiYearCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseCost { get; set; }
        public string Details { get; set; }
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
