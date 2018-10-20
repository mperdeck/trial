using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ImportTypeColumn")]
    public partial class ImportTypeColumn
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int Order { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int ImportTypeSheetId { get; set; }
        [Required]
        [StringLength(50)]
        public string FieldType { get; set; }
        [StringLength(50)]
        public string FieldLength { get; set; }
        public bool IsRequired { get; set; }
        [StringLength(100)]
        public string DefaultValue { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsForeignKey { get; set; }
        public bool IsIgnorable { get; set; }
        [StringLength(10)]
        public string SpecialFieldTypeId { get; set; }
        public bool IsMultiValueSelect { get; set; }
    }
}
