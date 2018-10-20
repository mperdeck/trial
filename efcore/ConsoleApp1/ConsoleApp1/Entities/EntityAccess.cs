using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("EntityAccess")]
    public partial class EntityAccess
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int UserId { get; set; }
        [Required]
        [StringLength(2)]
        public string EntityTypeId { get; set; }
        public int EntityId { get; set; }
        [Required]
        [StringLength(2)]
        public string AccessLevel { get; set; }
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
        [Required]
        [StringLength(5)]
        public string ApplicationId { get; set; }
        [Required]
        [StringLength(2)]
        public string ApplicationTypeId { get; set; }
    }
}
