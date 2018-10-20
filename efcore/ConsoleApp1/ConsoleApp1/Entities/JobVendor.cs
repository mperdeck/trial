using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("JobVendor")]
    public partial class JobVendor
    {
        public int Id { get; set; }
        public int BaseVersionId { get; set; }
        public int VersionNumber { get; set; }
        public int? SourceVersionId { get; set; }
        public int JobId { get; set; }
        [StringLength(1000)]
        public string EstimateFileName { get; set; }
        [StringLength(1000)]
        public string EstimateOriginalFileName { get; set; }
        [StringLength(1000)]
        public string ActualsFileName { get; set; }
        [StringLength(1000)]
        public string ActualsOriginalFileName { get; set; }
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
        [Column(TypeName = "money")]
        public decimal? DailyRate { get; set; }
        [Column(TypeName = "money")]
        public decimal? BaseDailyRate { get; set; }
        public string Comment { get; set; }
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
