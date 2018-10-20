using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("DynamicReport")]
    public partial class DynamicReport
    {
        public int Id { get; set; }
        public Guid ExtId { get; set; }
        [Required]
        [StringLength(3)]
        public string ModuleId { get; set; }
        public int SortOrdinal { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string DataSourceType { get; set; }
        [Required]
        [StringLength(1000)]
        public string DataSource { get; set; }
        public bool IsActive { get; set; }
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
