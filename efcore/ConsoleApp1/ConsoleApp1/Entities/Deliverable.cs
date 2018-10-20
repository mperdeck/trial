using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("Deliverable")]
    public partial class Deliverable
    {
        public int Id { get; set; }
        public int ScopeId { get; set; }
        public int AgencyDeliverableId { get; set; }
        public int InitiativeId { get; set; }
        public int SortOrdinal { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public decimal? OutOfPocket { get; set; }
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
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Quantity { get; set; }
        public string OutOfPocketDescription { get; set; }
        public int? ServiceComplexityId { get; set; }
        [StringLength(150)]
        public string Timeframe { get; set; }
        [StringLength(150)]
        public string EstimatedFee { get; set; }
        [StringLength(50)]
        public string ExternalId { get; set; }
        public int? DisciplineId { get; set; }
        public int BaseVersionId { get; set; }
        public int VersionNumber { get; set; }
        public int? SourceVersionId { get; set; }
        public bool IsFixedFee { get; set; }
        public bool IsProductionNeeded { get; set; }
        public int? ProbableProductionYear { get; set; }
        public int? ProbableProductionMonth { get; set; }
        public int? LocalCurrencyId { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseOutOfPocket { get; set; }
        public int? SubOrgUnitId { get; set; }
        public Guid ExtId { get; set; }
        public int? NumberOfElements { get; set; }
        public int? NumberOfRounds { get; set; }
        public int? DeliverableRateCardId { get; set; }
    }
}
