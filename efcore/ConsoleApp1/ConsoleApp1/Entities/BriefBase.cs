using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("BriefBase")]
    public partial class BriefBase
    {
        public int Id { get; set; }
        public int? CentralDocumentId { get; set; }
        public int BriefTemplateId { get; set; }
        [StringLength(500)]
        public string ContractAddress { get; set; }
        [StringLength(100)]
        public string ContractHolding { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractEnd { get; set; }
        [Column("MSADate", TypeName = "datetime")]
        public DateTime? Msadate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
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
        public Guid? ExtId { get; set; }
    }
}
