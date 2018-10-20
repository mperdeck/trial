using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ContractTemplateField")]
    public partial class ContractTemplateField
    {
        public int Id { get; set; }
        public int ContractTemplateId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public int SortOrdinal { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        public string MergeCode { get; set; }
        [Required]
        [StringLength(2)]
        public string FieldTypeId { get; set; }
        public string Value { get; set; }
        public bool IsAllowedOnTermsAndConditions { get; set; }
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
