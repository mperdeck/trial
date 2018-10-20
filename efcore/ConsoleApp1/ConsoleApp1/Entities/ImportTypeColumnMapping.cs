using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ImportTypeColumnMapping")]
    public partial class ImportTypeColumnMapping
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int MappingType { get; set; }
        public int ImportTypeColumnId { get; set; }
        [Required]
        [StringLength(50)]
        public string Entity { get; set; }
        [Required]
        [StringLength(50)]
        public string Column { get; set; }
        [Required]
        [StringLength(50)]
        public string ModelColumn { get; set; }
        [StringLength(50)]
        public string PrimaryKey { get; set; }
        [StringLength(50)]
        public string OrganizationKey { get; set; }
    }
}
