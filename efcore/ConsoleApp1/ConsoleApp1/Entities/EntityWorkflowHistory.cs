using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("EntityWorkflowHistory")]
    public partial class EntityWorkflowHistory
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        [Required]
        [StringLength(3)]
        public string EntityTypeId { get; set; }
        public int WorkflowId { get; set; }
        [Required]
        [StringLength(150)]
        public string WorkflowStepName { get; set; }
        public int Sequence { get; set; }
        [Required]
        [StringLength(2)]
        public string ActionId { get; set; }
        public int UserId { get; set; }
        [Required]
        [StringLength(60)]
        public string UserFullName { get; set; }
        [Required]
        [StringLength(2)]
        public string UserTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}
