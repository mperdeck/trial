using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ImportType")]
    public partial class ImportType
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Version { get; set; }
        [Required]
        [StringLength(200)]
        public string FileName { get; set; }
    }
}
