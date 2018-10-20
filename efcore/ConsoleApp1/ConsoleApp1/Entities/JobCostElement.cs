using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("JobCostElement")]
    public partial class JobCostElement
    {
        public int Id { get; set; }
        public int JobCostPhaseId { get; set; }
        public int AgencyElementId { get; set; }
        [StringLength(1)]
        public string CostPartyTypeId { get; set; }
        public int? ThirdPartySupplierId { get; set; }
        public string Note { get; set; }
        public string VariationComment { get; set; }
        [StringLength(1000)]
        public string FileName { get; set; }
        [StringLength(1000)]
        public string OriginalFileName { get; set; }
        public int? LocalClientCurrencyId { get; set; }
        [Column(TypeName = "money")]
        public decimal? OriginalEstimatedCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseOriginalEstimatedCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? CurrentEstimatedCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseCurrentEstimatedCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? ActualCost { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseActualCost { get; set; }
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
        public Guid ExtId { get; set; }
    }
}
