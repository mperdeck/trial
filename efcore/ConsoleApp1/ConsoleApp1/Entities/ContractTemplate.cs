using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ContractTemplate")]
    public partial class ContractTemplate
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        public string ContractBody { get; set; }
        public int ClientId { get; set; }
        public int SortOrdinal { get; set; }
        public bool IncludeSignatures { get; set; }
        public bool IncludeCostSummary { get; set; }
        public bool IncludeApprovals { get; set; }
        public bool DisplayElectronicApprovalDisclaimer { get; set; }
        public bool IncludeObjectives { get; set; }
        public bool IncludeServices { get; set; }
        public bool IncludeInitiatives { get; set; }
        public bool IncludeDeliverables { get; set; }
        public bool IncludeFunctions { get; set; }
        public bool IncludeResources { get; set; }
        public bool IncludeItems { get; set; }
        public bool IncludeVendors { get; set; }
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
        [Required]
        [StringLength(250)]
        public string TerminologyOverviewTitle { get; set; }
        [Required]
        public string TerminologyOverviewContent { get; set; }
        [Required]
        [StringLength(250)]
        public string TerminologyTermsAndConditionsTitle { get; set; }
        [Required]
        [StringLength(250)]
        public string TerminologyExhibitTitle { get; set; }
        [Required]
        [StringLength(250)]
        public string TerminologyAuthorizedSignatoriesTitle { get; set; }
        [Required]
        public string TerminologyAuthorizedSignatoriesContent { get; set; }
        public string TerminologyElectronicApprovalDisclaimer { get; set; }
        public bool IncludeDescription { get; set; }
        [StringLength(3)]
        public string ModuleId { get; set; }
        public int? AgencyStructureId { get; set; }
        public int? AccountTypeId { get; set; }
        public int? ClientGeographyId { get; set; }
        public int? ClientOrgUnitId { get; set; }
    }
}
