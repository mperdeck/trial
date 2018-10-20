using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("JobDeliverable")]
    public partial class JobDeliverable
    {
        public int Id { get; set; }
        public int BaseVersionId { get; set; }
        public int VersionNumber { get; set; }
        public int? SourceVersionId { get; set; }
        public int JobId { get; set; }
        public int ScopeDeliverableId { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? PercentageOfBudget { get; set; }
        public bool? IsPrimaryDeliverable { get; set; }
        [StringLength(50)]
        public string AdId { get; set; }
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
