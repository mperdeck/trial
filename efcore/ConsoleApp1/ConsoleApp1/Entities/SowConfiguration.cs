using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("SowConfiguration")]
    public partial class SowConfiguration
    {
        public int Id { get; set; }
        public bool AutopopulateDeliverableNames { get; set; }
        public bool MandatoryResourceNames { get; set; }
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
        public bool ShowObjectives { get; set; }
        public bool ShowServices { get; set; }
        public bool ShowMasterInitiatives { get; set; }
        [Required]
        public string ClientInstructions { get; set; }
        [Required]
        public string AgencyInstructions { get; set; }
        [StringLength(50)]
        public string TerminologyInitiative { get; set; }
        [StringLength(50)]
        public string TerminologyFunction { get; set; }
        [StringLength(50)]
        public string TerminologyDeliverable { get; set; }
        [StringLength(50)]
        public string TerminologyResource { get; set; }
        [Column("DefaultFTEHoursPerYear")]
        public int? DefaultFtehoursPerYear { get; set; }
        [Column("HideFTEHoursPerYear")]
        public bool HideFtehoursPerYear { get; set; }
        [Column("HideFTEsOnHourBasedScopes")]
        public bool HideFtesOnHourBasedScopes { get; set; }
        [Column("HideHoursOnFTEBasedScopes")]
        public bool HideHoursOnFtebasedScopes { get; set; }
        public bool AllowEditableInitiativeName { get; set; }
        public bool DeliverableComplexityVisible { get; set; }
        public bool DeliverableComplexityMandatory { get; set; }
        public bool DeliverableDisciplineVisible { get; set; }
        public bool DeliverableDisciplineMandatory { get; set; }
        public bool DeliverableNumberOfRoundsVisible { get; set; }
        public bool DeliverableNumberOfRoundsMandatory { get; set; }
        public bool DeliverableNumberOfElementsVisible { get; set; }
        public bool DeliverableNumberOfElementsMandatory { get; set; }
        public bool DeliverableFixedFeeVisible { get; set; }
        public bool ScopeStageVisible { get; set; }
        public bool ScopeStageMandatory { get; set; }
        public bool ScopeOverheadRateVisible { get; set; }
        public bool ScopeOverheadRateMandatory { get; set; }
        public bool ScopeProfitMarginVisible { get; set; }
        public bool ScopeProfitMarginMandatory { get; set; }
        public bool ScopeContractAddressVisible { get; set; }
        public bool ScopeContractAddressMandatory { get; set; }
        public bool ScopeHoldingCompanyVisible { get; set; }
        public bool ScopeHoldingCompanyMandatory { get; set; }
        [Column("ScopeMSADateVisible")]
        public bool ScopeMsadateVisible { get; set; }
        [Column("ScopeMSADateMandatory")]
        public bool ScopeMsadateMandatory { get; set; }
        public bool ScopeSummaryVisible { get; set; }
        public bool ScopeDescriptionVisible { get; set; }
        [StringLength(50)]
        public string TerminologyScopeItemGroup { get; set; }
        public bool NotifyNonScopeUsers { get; set; }
        public bool ShowRelationships { get; set; }
        public byte WorkgridDecimalPlaceholderFee { get; set; }
        public byte WorkgridDecimalPlaceholderRate { get; set; }
        public byte WorkgridDecimalPlaceholderHours { get; set; }
        [Column("WorkgridDecimalPlaceholderFTE")]
        public byte WorkgridDecimalPlaceholderFte { get; set; }
        public bool WorkgridAddRateColumn { get; set; }
    }
}
