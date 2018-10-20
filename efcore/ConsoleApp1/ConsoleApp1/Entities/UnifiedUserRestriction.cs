using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("UnifiedUserRestriction")]
    public partial class UnifiedUserRestriction
    {
        public int Id { get; set; }
        public Guid UnifiedUserId { get; set; }
        [Required]
        [StringLength(2)]
        public string EntityTypeId { get; set; }
        public int Value { get; set; }
    }
}
