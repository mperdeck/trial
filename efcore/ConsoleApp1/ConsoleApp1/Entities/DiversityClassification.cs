using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("DiversityClassification")]
    public partial class DiversityClassification
    {
        public int Id { get; set; }
        public int SortOrdinal { get; set; }
        [Required]
        [StringLength(1)]
        public string Code { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(150)]
        public string OldName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
