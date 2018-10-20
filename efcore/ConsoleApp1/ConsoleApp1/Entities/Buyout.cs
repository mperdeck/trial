using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("Buyout")]
    public partial class Buyout
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public int JobDeliverableId { get; set; }
        [StringLength(250)]
        public string Asset { get; set; }
        public bool? IsGlobalLocation { get; set; }
        public bool? IsUnlimitedDuration { get; set; }
        public int? Duration { get; set; }
        [StringLength(1)]
        public string DurationTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EstimatedFirstOnAirDate { get; set; }
        [Required]
        [StringLength(2)]
        public string GlidingTypeId { get; set; }
        public string OngoingRights { get; set; }
        public string Comments { get; set; }
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
    }
}
