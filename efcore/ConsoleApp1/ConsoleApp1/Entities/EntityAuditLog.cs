using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("EntityAuditLog")]
    public partial class EntityAuditLog
    {
        public int Id { get; set; }
        public int EntityAuditLogTypeId { get; set; }
        public int EntityId { get; set; }
        [StringLength(150)]
        public string EntityName { get; set; }
        [Required]
        [StringLength(5)]
        public string Action { get; set; }
        [Required]
        [StringLength(2)]
        public string UserType { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        public Guid UnifiedUserId { get; set; }
        public int? ParentEntityTypeId { get; set; }
        public int? ParentEntityId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
    }
}
