using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ContractTemplateDocument")]
    public partial class ContractTemplateDocument
    {
        public int Id { get; set; }
        public int ContractTemplateId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public int SortOrdinal { get; set; }
        [Required]
        [StringLength(3)]
        public string FileTypeId { get; set; }
        [Required]
        [StringLength(2)]
        public string WhenUploadedId { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Required]
        [StringLength(150)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }
        [StringLength(150)]
        public string LastUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDeleted { get; set; }
        [StringLength(150)]
        public string DeletedBy { get; set; }
    }
}
