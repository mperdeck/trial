using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("EntityWorkflowStep")]
    public partial class EntityWorkflowStep
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        [Required]
        [StringLength(3)]
        public string EntityTypeId { get; set; }
        public int WorkflowStepId { get; set; }
        public int? UserId { get; set; }
        public bool IsSubmitted { get; set; }
        [StringLength(25)]
        public string ApproverName { get; set; }
    }
}
