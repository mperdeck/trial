using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("Service")]
    public partial class Service
    {
        public int Id { get; set; }
        public int ScopeId { get; set; }
        public int AgencyServiceId { get; set; }
        public int? ServiceComplexityId { get; set; }
        public int SortOrdinal { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
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
        public int BaseVersionId { get; set; }
        public int VersionNumber { get; set; }
        public int? SourceVersionId { get; set; }
        public Guid ExtId { get; set; }
    }
}
