using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ApplicationAlert")]
    public partial class ApplicationAlert
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string AlertType { get; set; }
        public string Message { get; set; }
        public bool ShowTimeZoneInformation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateTime { get; set; }
        public int? Duration { get; set; }
        public int? AlertLocations { get; set; }
        public bool IsActive { get; set; }
    }
}
