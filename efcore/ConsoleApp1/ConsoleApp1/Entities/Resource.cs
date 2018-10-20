using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("Resource")]
    public partial class Resource
    {
        public int Id { get; set; }
        public int ScopeId { get; set; }
        public int FunctionId { get; set; }
        public int AgencyRoleId { get; set; }
        public int SortOrdinal { get; set; }
        [Column(TypeName = "decimal(28, 15)")]
        public decimal? Rate { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateDeleted { get; set; }
        [Required]
        [StringLength(150)]
        public string CreatedBy { get; set; }
        [StringLength(150)]
        public string LastUpdatedBy { get; set; }
        [StringLength(150)]
        public string DeletedBy { get; set; }
        [StringLength(100)]
        public string Location { get; set; }
        [StringLength(150)]
        public string JobTitle { get; set; }
        [Required]
        [StringLength(2)]
        public string BillingTypeId { get; set; }
        public bool KeyResource { get; set; }
        [StringLength(50)]
        public string ExternalId { get; set; }
        public int BaseVersionId { get; set; }
        public int VersionNumber { get; set; }
        public int? SourceVersionId { get; set; }
        public int? LocalCurrencyId { get; set; }
        [Column(TypeName = "decimal(28, 15)")]
        public decimal? BaseRate { get; set; }
        public Guid ExtId { get; set; }
        public int? RateCardId { get; set; }
    }
}
