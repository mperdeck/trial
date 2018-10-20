using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ImportTypeSheet")]
    public partial class ImportTypeSheet
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int ImportTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string AlternateName { get; set; }
        public int ColumnOffset { get; set; }
        public int RowOffset { get; set; }
        public int Sequence { get; set; }
        [StringLength(10)]
        public string SheetOrientation { get; set; }
    }
}
