using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("JobCostPhase")]
    public partial class JobCostPhase
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int AgencyPhaseId { get; set; }
        public int? TotalDays { get; set; }
        public int? SubTotalDaysA { get; set; }
        public int? SubTotalDaysB { get; set; }
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
