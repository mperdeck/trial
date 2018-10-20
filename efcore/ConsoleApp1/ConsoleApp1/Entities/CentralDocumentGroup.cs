using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("CentralDocumentGroup")]
    public partial class CentralDocumentGroup
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        public int ClientId { get; set; }
        public int? BudgetPeriodId { get; set; }
        public int SortOrdinal { get; set; }
        public bool? IsActive { get; set; }
        [StringLength(3)]
        public string ModuleId { get; set; }
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
        public Guid ExtId { get; set; }
    }
}
