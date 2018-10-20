using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("PlatformEmailJob")]
    public partial class PlatformEmailJob
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(3)]
        public string EntityTypeId { get; set; }
        [Required]
        [StringLength(2)]
        public string ApplicationUserTypeId { get; set; }
        [Required]
        [StringLength(2)]
        public string EntityUserTypeId { get; set; }
        public int? BudgetPeriodId { get; set; }
        [Required]
        [StringLength(255)]
        public string EmailSubject { get; set; }
        [Required]
        [StringLength(5000)]
        public string AdminMessageTemplate { get; set; }
        [Required]
        [StringLength(5000)]
        public string UserMessageTemplate { get; set; }
        [Required]
        [StringLength(100)]
        public string FromEmailAddress { get; set; }
        [Required]
        [StringLength(100)]
        public string FromEmailName { get; set; }
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
        public int? AgencyId { get; set; }
        public int? CentralDocumentId { get; set; }
        public int? AccountTypeId { get; set; }
        public int? ClientOrgUnitId { get; set; }
        public int? ClientGeographyId { get; set; }
    }
}
