using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("org")]
    public partial class Org
    {
        [Column("org_id")]
        public int OrgId { get; set; }
        [Required]
        [Column("org_reference")]
        [StringLength(10)]
        public string OrgReference { get; set; }
        [Required]
        [Column("org_name")]
        [StringLength(50)]
        public string OrgName { get; set; }
        [Column("client_supplier")]
        [StringLength(1)]
        public string ClientSupplier { get; set; }
        [Column("evaluation_type")]
        [StringLength(5)]
        public string EvaluationType { get; set; }
        [Column("owner_org_id")]
        public int? OwnerOrgId { get; set; }
        [Column("owner_agency")]
        public int? OwnerAgency { get; set; }
        [Column("can_uncomplete")]
        [StringLength(1)]
        public string CanUncomplete { get; set; }
        [Column("can_create")]
        [StringLength(1)]
        public string CanCreate { get; set; }
        [Column("use_custorgunit")]
        [StringLength(1)]
        public string UseCustorgunit { get; set; }
        [Column("use_geography")]
        [StringLength(1)]
        public string UseGeography { get; set; }
        [Column("use_acctype")]
        [StringLength(1)]
        public string UseAcctype { get; set; }
        [Column("use_subacctype")]
        [StringLength(1)]
        public string UseSubacctype { get; set; }
        [Column("use_submit_date")]
        [StringLength(1)]
        public string UseSubmitDate { get; set; }
        [Column("use_review_dates")]
        [StringLength(1)]
        public string UseReviewDates { get; set; }
        [Column("use_auto_email")]
        [StringLength(1)]
        public string UseAutoEmail { get; set; }
        [Column("use_quant_measure")]
        [StringLength(1)]
        public string UseQuantMeasure { get; set; }
        [Column("use_owner_override")]
        [StringLength(1)]
        public string UseOwnerOverride { get; set; }
        [Column("use_location")]
        [StringLength(1)]
        public string UseLocation { get; set; }
        [Column("use_assesstype")]
        [StringLength(1)]
        public string UseAssesstype { get; set; }
        [Column("assesstype_level")]
        [StringLength(1)]
        public string AssesstypeLevel { get; set; }
        [Column("use_jobfunction")]
        [StringLength(1)]
        public string UseJobfunction { get; set; }
        [Column("use_evaluatorgroup")]
        [StringLength(1)]
        public string UseEvaluatorgroup { get; set; }
        [Column("use_global_report")]
        [StringLength(1)]
        public string UseGlobalReport { get; set; }
        [Column("use_promoter")]
        [StringLength(1)]
        public string UsePromoter { get; set; }
        [Column("use_roster")]
        [StringLength(1)]
        public string UseRoster { get; set; }
        [Column("use_sow")]
        [StringLength(1)]
        public string UseSow { get; set; }
        [Column("use_factmpldw")]
        [StringLength(1)]
        public string UseFactmpldw { get; set; }
        [Column("show_factormst_short")]
        [StringLength(1)]
        public string ShowFactormstShort { get; set; }
        [Column("share_review_reports")]
        [StringLength(1)]
        public string ShareReviewReports { get; set; }
        [Column("use_sign_external")]
        [StringLength(1)]
        public string UseSignExternal { get; set; }
        [Column("use_signatory")]
        [StringLength(1)]
        public string UseSignatory { get; set; }
        [Column("use_priority")]
        [StringLength(1)]
        public string UsePriority { get; set; }
        [Column("priority")]
        [StringLength(1)]
        public string Priority { get; set; }
        [Column("use_onwatch")]
        [StringLength(1)]
        public string UseOnwatch { get; set; }
        [Column("use_onwatch_auto")]
        [StringLength(1)]
        public string UseOnwatchAuto { get; set; }
        [Column("use_agency_details")]
        [StringLength(1)]
        public string UseAgencyDetails { get; set; }
        [Column("use_minority_vendor")]
        [StringLength(1)]
        public string UseMinorityVendor { get; set; }
        [Column("use_action_plan")]
        [StringLength(1)]
        public string UseActionPlan { get; set; }
        [Column("use_owner_reopen_review")]
        [StringLength(1)]
        public string UseOwnerReopenReview { get; set; }
        [Column("owner_reopen_review_action")]
        [StringLength(15)]
        public string OwnerReopenReviewAction { get; set; }
        [Column("custorgunit_id")]
        public int? CustorgunitId { get; set; }
        [Column("default_submit_week")]
        public int? DefaultSubmitWeek { get; set; }
        [Column("orgunit_pl_lang")]
        [StringLength(50)]
        public string OrgunitPlLang { get; set; }
        [Column("decision_pl_lang")]
        [StringLength(50)]
        public string DecisionPlLang { get; set; }
        [Column("acctype_pl_lang")]
        [StringLength(50)]
        public string AcctypePlLang { get; set; }
        [Column("scale")]
        public double? Scale { get; set; }
        [Column("shift")]
        public short? Shift { get; set; }
        [Column("rounding")]
        public short? Rounding { get; set; }
        [Required]
        [Column("active")]
        [StringLength(1)]
        public string Active { get; set; }
        [Column("clone_org_id")]
        public int? CloneOrgId { get; set; }
        [Column("org_ext")]
        public Guid? OrgExt { get; set; }
        [Column("use_decperiod")]
        [StringLength(1)]
        public string UseDecperiod { get; set; }
        [Column("collect_pharma_data")]
        [StringLength(1)]
        public string CollectPharmaData { get; set; }
        [Column("password_complexity")]
        public short PasswordComplexity { get; set; }
        [Column("password_expiry_day")]
        public short PasswordExpiryDay { get; set; }
        [Column("password_history_remembered")]
        public short PasswordHistoryRemembered { get; set; }
        [Column("inactive_timeout")]
        public short InactiveTimeout { get; set; }
        [Column("use_sso")]
        [StringLength(1)]
        public string UseSso { get; set; }
        [Column("sso_profile_id")]
        public int? SsoProfileId { get; set; }
        [Column("use_briefing")]
        [StringLength(1)]
        public string UseBriefing { get; set; }
        [Column("use_evaluation")]
        [StringLength(1)]
        public string UseEvaluation { get; set; }
        [Column("use_sustainability")]
        [StringLength(1)]
        public string UseSustainability { get; set; }
        [Column("use_segment")]
        [StringLength(1)]
        public string UseSegment { get; set; }
        [Column("use_dashboard")]
        [StringLength(1)]
        public string UseDashboard { get; set; }
        [Column("use_knowledge_base")]
        [StringLength(1)]
        public string UseKnowledgeBase { get; set; }
        [Column("use_production")]
        [StringLength(1)]
        public string UseProduction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [StringLength(150)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }
        [StringLength(150)]
        public string LastUpdatedBy { get; set; }
        [StringLength(50)]
        public string VendorNumber { get; set; }
        public short PasswordMinCharacters { get; set; }
        [Column("org_name_extended")]
        [StringLength(200)]
        public string OrgNameExtended { get; set; }
        [Column("allow_cross_agency")]
        [StringLength(1)]
        public string AllowCrossAgency { get; set; }
        public int AdministratorLimit { get; set; }
        public int SystemAdministratorLimit { get; set; }
    }
}
