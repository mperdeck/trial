using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("EntityContractDocument")]
    public partial class EntityContractDocument
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        [Required]
        [StringLength(3)]
        public string EntityTypeId { get; set; }
        public int ContractTemplateDocumentId { get; set; }
        [Required]
        [StringLength(150)]
        public string FileName { get; set; }
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
