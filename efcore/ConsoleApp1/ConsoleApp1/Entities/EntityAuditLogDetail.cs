using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("EntityAuditLogDetail")]
    public partial class EntityAuditLogDetail
    {
        public int Id { get; set; }
        public int EntityAuditLogId { get; set; }
        [Required]
        [StringLength(30)]
        public string FieldName { get; set; }
        public string FieldOldValue { get; set; }
        public string FieldNewValue { get; set; }
    }
}
