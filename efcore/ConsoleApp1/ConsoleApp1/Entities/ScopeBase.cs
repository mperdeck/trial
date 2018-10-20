using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ScopeBase")]
    public partial class ScopeBase
    {
        public int Id { get; set; }
        public int? CentralDocumentId { get; set; }
        [Required]
        [StringLength(2)]
        public string FeeTypeId { get; set; }
        [Column("FTEHoursPerYear")]
        public int FtehoursPerYear { get; set; }
        [Column(TypeName = "money")]
        public decimal? BlendedRate { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? OverheadRate { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? ProfitMargin { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Required]
        [StringLength(150)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }
        [StringLength(150)]
        public string LastUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDeleted { get; set; }
        [StringLength(150)]
        public string DeletedBy { get; set; }
        [StringLength(500)]
        public string ContractAddress { get; set; }
        [StringLength(100)]
        public string ContractHolding { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractEnd { get; set; }
        public int? RateCardId { get; set; }
        [Column(TypeName = "money")]
        public decimal? Bonus { get; set; }
        [Column(TypeName = "money")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "money")]
        public decimal? InternalBudget { get; set; }
        [Column("MSADate", TypeName = "datetime")]
        public DateTime? Msadate { get; set; }
        [StringLength(1)]
        public string ReconciliationFrequencyId { get; set; }
        [Required]
        [StringLength(2)]
        public string Duration { get; set; }
        public int? DeliverableRateCardId { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseBonus { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseDiscount { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseInternalBudget { get; set; }
        public Guid ExtId { get; set; }
        [Column("PONumber")]
        [StringLength(50)]
        public string Ponumber { get; set; }
        [StringLength(100)]
        public string ContractNumber { get; set; }
        public bool? AllowMultipleRoleRateCards { get; set; }
        public bool? AllowMultipleDeliverableRateCards { get; set; }
    }
}
