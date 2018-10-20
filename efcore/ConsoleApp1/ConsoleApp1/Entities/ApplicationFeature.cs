using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ApplicationFeature")]
    public partial class ApplicationFeature
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        [Required]
        [StringLength(5)]
        public string ModuleId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
