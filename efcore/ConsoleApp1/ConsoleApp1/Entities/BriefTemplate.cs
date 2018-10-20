using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("BriefTemplate")]
    public partial class BriefTemplate
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int SortOrdinal { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Instructions { get; set; }
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
        public bool IsActive { get; set; }
        public Guid ExtId { get; set; }
    }
}
