using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp1.Entities
{
    public partial class OptimizewareContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=MPERDECKPC\\MSSQLSERVER01;Initial Catalog=optimizeware;Integrated Security=True");
            }
        }

        public virtual DbSet<Accountweighting> Accountweightings { get; set; }
        public virtual DbSet<Acctype> Acctypes { get; set; }
        public virtual DbSet<Actual> Actuals { get; set; }
        public virtual DbSet<ActualDeliverable> ActualDeliverables { get; set; }
        public virtual DbSet<ActualExpense> ActualExpenses { get; set; }
        public virtual DbSet<ActualFee> ActualFees { get; set; }
        public virtual DbSet<AgencyDeliverable> AgencyDeliverables { get; set; }
        public virtual DbSet<AgencyElement> AgencyElements { get; set; }
        public virtual DbSet<AgencyExpense> AgencyExpenses { get; set; }
        public virtual DbSet<AgencyFunction> AgencyFunctions { get; set; }
        public virtual DbSet<AgencyInitiative> AgencyInitiatives { get; set; }
        public virtual DbSet<AgencyObjective> AgencyObjectives { get; set; }
        public virtual DbSet<AgencyPhase> AgencyPhases { get; set; }
        public virtual DbSet<AgencyRole> AgencyRoles { get; set; }
        public virtual DbSet<AgencyService> AgencyServices { get; set; }
        public virtual DbSet<Ansmst> Ansmsts { get; set; }
        public virtual DbSet<Ansval> Ansvals { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<ApplicationAlert> ApplicationAlerts { get; set; }
        public virtual DbSet<ApplicationFeature> ApplicationFeatures { get; set; }
        public virtual DbSet<ApplicationVersionHistory> ApplicationVersionHistories { get; set; }
        public virtual DbSet<AspstateTempApplication> AspstateTempApplications { get; set; }
        public virtual DbSet<AspstateTempSession> AspstateTempSessions { get; set; }
        public virtual DbSet<Assessor> Assessors { get; set; }
        public virtual DbSet<Assessortmp> Assessortmps { get; set; }
        public virtual DbSet<Assesstype> Assesstypes { get; set; }
        public virtual DbSet<AutoEmailerHistory> AutoEmailerHistories { get; set; }
        public virtual DbSet<Batchresult> Batchresults { get; set; }
        public virtual DbSet<BriefAnswerOption> BriefAnswerOptions { get; set; }
        public virtual DbSet<BriefAnswerText> BriefAnswerTexts { get; set; }
        public virtual DbSet<BriefBase> BriefBases { get; set; }
        public virtual DbSet<BriefContractDocument> BriefContractDocuments { get; set; }
        public virtual DbSet<BriefField> BriefFields { get; set; }
        public virtual DbSet<BriefingConfiguration> BriefingConfigurations { get; set; }
        public virtual DbSet<BriefingEmailJob> BriefingEmailJobs { get; set; }
        public virtual DbSet<BriefingEmailNotification> BriefingEmailNotifications { get; set; }
        public virtual DbSet<BriefingEmailRun> BriefingEmailRuns { get; set; }
        public virtual DbSet<BriefTemplate> BriefTemplates { get; set; }
        public virtual DbSet<BriefTemplateQuestion> BriefTemplateQuestions { get; set; }
        public virtual DbSet<BriefTemplateQuestionOption> BriefTemplateQuestionOptions { get; set; }
        public virtual DbSet<BudgetPeriod> BudgetPeriods { get; set; }
        public virtual DbSet<Buyout> Buyouts { get; set; }
        public virtual DbSet<BuyoutCountry> BuyoutCountries { get; set; }
        public virtual DbSet<BuyoutMediaMaterial> BuyoutMediaMaterials { get; set; }
        public virtual DbSet<CentralDocumentGroup> CentralDocumentGroups { get; set; }
        public virtual DbSet<Checklist> Checklists { get; set; }
        public virtual DbSet<Checkmst> Checkmsts { get; set; }
        public virtual DbSet<Choicep> Choiceps { get; set; }
        public virtual DbSet<Choicepr> Choiceprs { get; set; }
        public virtual DbSet<Choicepw> Choicepws { get; set; }
        public virtual DbSet<Choicer> Choicers { get; set; }
        public virtual DbSet<Choicew> Choicews { get; set; }
        public virtual DbSet<ClientCurrency> ClientCurrencies { get; set; }
        public virtual DbSet<ClientDiversityClassification> ClientDiversityClassifications { get; set; }
        public virtual DbSet<ClientFeeType> ClientFeeTypes { get; set; }
        public virtual DbSet<Compare> Compares { get; set; }
        public virtual DbSet<Conflict> Conflicts { get; set; }
        public virtual DbSet<ContractTemplate> ContractTemplates { get; set; }
        public virtual DbSet<ContractTemplateDocument> ContractTemplateDocuments { get; set; }
        public virtual DbSet<ContractTemplateField> ContractTemplateFields { get; set; }
        public virtual DbSet<CostTemplate> CostTemplates { get; set; }
        public virtual DbSet<CostTemplateElement> CostTemplateElements { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Custpersaccassess> Custpersaccassesses { get; set; }
        public virtual DbSet<Custpersassess> Custpersassesses { get; set; }
        public virtual DbSet<Custpersupd> Custpersupds { get; set; }
        public virtual DbSet<DecidewareConfiguration> DecidewareConfigurations { get; set; }
        public virtual DbSet<Decisionloc> Decisionlocs { get; set; }
        public virtual DbSet<Decperiod> Decperiods { get; set; }
        public virtual DbSet<Deliverable> Deliverables { get; set; }
        public virtual DbSet<DeliverableRateCard> DeliverableRateCards { get; set; }
        public virtual DbSet<DeliverableRateCardDeliverable> DeliverableRateCardDeliverables { get; set; }
        public virtual DbSet<Discipline> Disciplines { get; set; }
        public virtual DbSet<DiversityClassification> DiversityClassifications { get; set; }
        public virtual DbSet<DynamicReport> DynamicReports { get; set; }
        public virtual DbSet<Emailflow> Emailflows { get; set; }
        public virtual DbSet<EmailTemp> EmailTemps { get; set; }
        public virtual DbSet<Emailtmpl> Emailtmpls { get; set; }
        public virtual DbSet<EntityAccess> EntityAccesses { get; set; }
        public virtual DbSet<EntityAuditLog> EntityAuditLogs { get; set; }
        public virtual DbSet<EntityAuditLogDetail> EntityAuditLogDetails { get; set; }
        public virtual DbSet<EntityAuditLogType> EntityAuditLogTypes { get; set; }
        public virtual DbSet<EntityContractDocument> EntityContractDocuments { get; set; }
        public virtual DbSet<EntityField> EntityFields { get; set; }
        public virtual DbSet<EntityWorkflowHistory> EntityWorkflowHistories { get; set; }
        public virtual DbSet<EntityWorkflowStep> EntityWorkflowSteps { get; set; }
        public virtual DbSet<Errorlog> Errorlogs { get; set; }
        public virtual DbSet<Evaluatorgroup> Evaluatorgroups { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Facassess> Facassesses { get; set; }
        public virtual DbSet<Facmst> Facmsts { get; set; }
        public virtual DbSet<Facmstm> Facmstms { get; set; }
        public virtual DbSet<Factmpldw> Factmpldws { get; set; }
        public virtual DbSet<Factordata> Factordatas { get; set; }
        public virtual DbSet<Factormst> Factormsts { get; set; }
        public virtual DbSet<Factscale> Factscales { get; set; }
        public virtual DbSet<Factscalem> Factscalems { get; set; }
        public virtual DbSet<Function> Functions { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
        public virtual DbSet<ImportArchive> ImportArchives { get; set; }
        public virtual DbSet<ImportSheet> ImportSheets { get; set; }
        public virtual DbSet<ImportType> ImportTypes { get; set; }
        public virtual DbSet<ImportTypeColumn> ImportTypeColumns { get; set; }
        public virtual DbSet<ImportTypeColumnMapping> ImportTypeColumnMappings { get; set; }
        public virtual DbSet<ImportTypeSheet> ImportTypeSheets { get; set; }
        public virtual DbSet<Initiative> Initiatives { get; set; }
        public virtual DbSet<ItemCategory> ItemCategories { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<JobBase> JobBases { get; set; }
        public virtual DbSet<JobContractDocument> JobContractDocuments { get; set; }
        public virtual DbSet<JobCostElement> JobCostElements { get; set; }
        public virtual DbSet<JobCostPhase> JobCostPhases { get; set; }
        public virtual DbSet<JobDeliverable> JobDeliverables { get; set; }
        public virtual DbSet<JobField> JobFields { get; set; }
        public virtual DbSet<Jobfunction> Jobfunctions { get; set; }
        public virtual DbSet<JobTripleBidDocument> JobTripleBidDocuments { get; set; }
        public virtual DbSet<JobVendor> JobVendors { get; set; }
        public virtual DbSet<KnowledgeComment> KnowledgeComments { get; set; }
        public virtual DbSet<KnowledgeCommentTag> KnowledgeCommentTags { get; set; }
        public virtual DbSet<KnowledgeMood> KnowledgeMoods { get; set; }
        public virtual DbSet<KnowledgeTag> KnowledgeTags { get; set; }
        public virtual DbSet<LeadUser> LeadUsers { get; set; }
        public virtual DbSet<LegalEntity> LegalEntities { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MediaMaterial> MediaMaterials { get; set; }
        public virtual DbSet<Objective> Objectives { get; set; }
        public virtual DbSet<Org> Orgs { get; set; }
        public virtual DbSet<OrganizationApplicationFeature> OrganizationApplicationFeatures { get; set; }
        public virtual DbSet<PasswordHistory> PasswordHistories { get; set; }
        public virtual DbSet<PlatformEmailJob> PlatformEmailJobs { get; set; }
        public virtual DbSet<PlatformEmailNotification> PlatformEmailNotifications { get; set; }
        public virtual DbSet<PlatformEmailRun> PlatformEmailRuns { get; set; }
        public virtual DbSet<ProductionConfiguration> ProductionConfigurations { get; set; }
        public virtual DbSet<ProductionType> ProductionTypes { get; set; }
        public virtual DbSet<Quesmst> Quesmsts { get; set; }
        public virtual DbSet<RateCard> RateCards { get; set; }
        public virtual DbSet<RateCardRole> RateCardRoles { get; set; }
        public virtual DbSet<ReconciliationPeriod> ReconciliationPeriods { get; set; }
        public virtual DbSet<Repacctype> Repacctypes { get; set; }
        public virtual DbSet<Repcustorgunit> Repcustorgunits { get; set; }
        public virtual DbSet<Repfactdec> Repfactdecs { get; set; }
        public virtual DbSet<Repgeography> Repgeographies { get; set; }
        public virtual DbSet<Reporgunit> Reporgunits { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Reportbatch> Reportbatches { get; set; }
        public virtual DbSet<Reportcolumn> Reportcolumns { get; set; }
        public virtual DbSet<Reportconfig> Reportconfigs { get; set; }
        public virtual DbSet<Reportparam> Reportparams { get; set; }
        public virtual DbSet<Repsegment> Repsegments { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Rfactmpl> Rfactmpls { get; set; }
        public virtual DbSet<RoleSeniority> RoleSeniorities { get; set; }
        public virtual DbSet<ScopeBase> ScopeBases { get; set; }
        public virtual DbSet<ScopeContractDocument> ScopeContractDocuments { get; set; }
        public virtual DbSet<ScopeFee> ScopeFees { get; set; }
        public virtual DbSet<ScopeField> ScopeFields { get; set; }
        public virtual DbSet<ScopeItem> ScopeItems { get; set; }
        public virtual DbSet<ScopeItemGroup> ScopeItemGroups { get; set; }
        public virtual DbSet<ScopePeriod> ScopePeriods { get; set; }
        public virtual DbSet<Scorecarddoc> Scorecarddocs { get; set; }
        public virtual DbSet<Segment> Segments { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceComplexity> ServiceComplexities { get; set; }
        public virtual DbSet<ServiceSegment> ServiceSegments { get; set; }
        public virtual DbSet<ServiceServiceSegment> ServiceServiceSegments { get; set; }
        public virtual DbSet<ShootType> ShootTypes { get; set; }
        public virtual DbSet<Signature> Signatures { get; set; }
        public virtual DbSet<SowConfiguration> SowConfigurations { get; set; }
        public virtual DbSet<SowEmailJob> SowEmailJobs { get; set; }
        public virtual DbSet<SowEmailNotification> SowEmailNotifications { get; set; }
        public virtual DbSet<SowEmailRun> SowEmailRuns { get; set; }
        public virtual DbSet<SsoProfile> SsoProfiles { get; set; }
        public virtual DbSet<Stage> Stages { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Teamspecr> Teamspecrs { get; set; }
        public virtual DbSet<ThirdPartySupplier> ThirdPartySuppliers { get; set; }
        public virtual DbSet<ThirdPartySupplierCategory> ThirdPartySupplierCategories { get; set; }
        public virtual DbSet<TimeZone> TimeZones { get; set; }
        public virtual DbSet<TripleBid> TripleBids { get; set; }
        public virtual DbSet<UnifiedUserRestriction> UnifiedUserRestrictions { get; set; }
        public virtual DbSet<Workflow> Workflows { get; set; }
        public virtual DbSet<WorkflowHistory> WorkflowHistories { get; set; }
        public virtual DbSet<WorkflowStep> WorkflowSteps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accountweighting>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.PeriodId });
            });

            modelBuilder.Entity<Acctype>(entity =>
            {
                entity.Property(e => e.AcctypePl).IsUnicode(false);

                entity.Property(e => e.AcctypeShort).IsUnicode(false);

                entity.Property(e => e.Active).IsUnicode(false);
            });

            modelBuilder.Entity<Actual>(entity =>
            {
                entity.Property(e => e.ApprovalStatus).IsUnicode(false);

                entity.Property(e => e.FeeTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<Ansmst>(entity =>
            {
                entity.Property(e => e.AnsmstShort).IsUnicode(false);
            });

            modelBuilder.Entity<Ansval>(entity =>
            {
                entity.HasKey(e => new { e.DecisionId, e.CustpersId, e.QuesmstId });
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.HasKey(e => new { e.DecisionId, e.CustpersId, e.AnsmstId });

                entity.Property(e => e.AnswerFlag).IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationFeature>(entity =>
            {
                entity.Property(e => e.ModuleId).IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationVersionHistory>(entity =>
            {
                entity.Property(e => e.ApplicationId).IsUnicode(false);

                entity.Property(e => e.Version).IsUnicode(false);
            });

            modelBuilder.Entity<AspstateTempApplication>(entity =>
            {
                entity.Property(e => e.AppId).ValueGeneratedNever();

                entity.Property(e => e.AppName).IsUnicode(false);
            });

            modelBuilder.Entity<AspstateTempSession>(entity =>
            {
                entity.Property(e => e.SessionId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Assessor>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.CustpersId });

                entity.Property(e => e.AssessorId).ValueGeneratedOnAdd();

                entity.Property(e => e.AssessorType).IsUnicode(false);

                entity.Property(e => e.DecisionOwner).IsUnicode(false);

                entity.Property(e => e.IndividualEvaluator).IsUnicode(false);

                entity.Property(e => e.ReadOnlyOwner).IsUnicode(false);

                entity.Property(e => e.Signatory).IsUnicode(false);

                entity.Property(e => e.ViewReports).IsUnicode(false);
            });

            modelBuilder.Entity<Assessortmp>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.CustpersId, e.AssessorType });

                entity.Property(e => e.AssessorType).IsUnicode(false);
            });

            modelBuilder.Entity<Assesstype>(entity =>
            {
                entity.Property(e => e.AssesstypeShort).IsUnicode(false);
            });

            modelBuilder.Entity<AutoEmailerHistory>(entity =>
            {
                entity.Property(e => e.JobId).IsUnicode(false);

                entity.Property(e => e.OrgName).IsUnicode(false);

                entity.Property(e => e.OrgReference).IsUnicode(false);

                entity.Property(e => e.SentStatus).IsUnicode(false);

                entity.Property(e => e.UserFirstName).IsUnicode(false);

                entity.Property(e => e.UserLastName).IsUnicode(false);

                entity.Property(e => e.UserType).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<Batchresult>(entity =>
            {
                entity.Property(e => e.BatchId).ValueGeneratedNever();
            });

            modelBuilder.Entity<BriefingConfiguration>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<BriefingEmailJob>(entity =>
            {
                entity.Property(e => e.AdminMessageTemplate).IsUnicode(false);

                entity.Property(e => e.ApplicationUserTypeId).IsUnicode(false);

                entity.Property(e => e.BriefUserTypeId).IsUnicode(false);

                entity.Property(e => e.EmailSubject).IsUnicode(false);

                entity.Property(e => e.UserMessageTemplate).IsUnicode(false);
            });

            modelBuilder.Entity<BriefingEmailNotification>(entity =>
            {
                entity.Property(e => e.OrgName).IsUnicode(false);

                entity.Property(e => e.OrgReference).IsUnicode(false);

                entity.Property(e => e.UserFirstName).IsUnicode(false);

                entity.Property(e => e.UserLastName).IsUnicode(false);

                entity.Property(e => e.UserTypeId).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<BriefingEmailRun>(entity =>
            {
                entity.Property(e => e.RunTypeId).IsUnicode(false);

                entity.Property(e => e.StatusId).IsUnicode(false);
            });

            modelBuilder.Entity<BriefTemplateQuestion>(entity =>
            {
                entity.Property(e => e.QuestionTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<Buyout>(entity =>
            {
                entity.Property(e => e.DurationTypeId).IsUnicode(false);

                entity.Property(e => e.GlidingTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<BuyoutCountry>(entity =>
            {
                entity.HasKey(e => new { e.BuyoutId, e.CountryId });
            });

            modelBuilder.Entity<BuyoutMediaMaterial>(entity =>
            {
                entity.HasKey(e => new { e.BuyoutId, e.MediaMaterialId });
            });

            modelBuilder.Entity<Checklist>(entity =>
            {
                entity.Property(e => e.Checked).IsUnicode(false);
            });

            modelBuilder.Entity<Checkmst>(entity =>
            {
                entity.Property(e => e.CheckmstName).IsUnicode(false);
            });

            modelBuilder.Entity<Choicep>(entity =>
            {
                entity.HasKey(e => new { e.CustpersId, e.ChoiceId });

                entity.Property(e => e.Complete).IsUnicode(false);
            });

            modelBuilder.Entity<Choicepr>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.CustpersId, e.FactmplId });
            });

            modelBuilder.Entity<Choicepw>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.CustpersId, e.FactmplId });
            });

            modelBuilder.Entity<Choicer>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.FactmplId });
            });

            modelBuilder.Entity<Choicew>(entity =>
            {
                entity.HasKey(e => new { e.ChoiceId, e.FactmplId });
            });

            modelBuilder.Entity<ClientFeeType>(entity =>
            {
                entity.Property(e => e.FeeTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<Compare>(entity =>
            {
                entity.Property(e => e.CompareId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CompareShort).IsUnicode(false);
            });

            modelBuilder.Entity<Conflict>(entity =>
            {
                entity.Property(e => e.ConflictShort).IsUnicode(false);
            });

            modelBuilder.Entity<ContractTemplateDocument>(entity =>
            {
                entity.Property(e => e.FileTypeId).IsUnicode(false);

                entity.Property(e => e.WhenUploadedId).IsUnicode(false);
            });

            modelBuilder.Entity<ContractTemplateField>(entity =>
            {
                entity.Property(e => e.FieldTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Iso2).IsUnicode(false);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);
            });

            modelBuilder.Entity<Custpersaccassess>(entity =>
            {
                entity.HasKey(e => new { e.CustpersId, e.AccountId, e.AssesstypeId });
            });

            modelBuilder.Entity<Custpersassess>(entity =>
            {
                entity.HasKey(e => new { e.CustpersId, e.AssesstypeId });
            });

            modelBuilder.Entity<Custpersupd>(entity =>
            {
                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Surname).IsUnicode(false);
            });

            modelBuilder.Entity<DecidewareConfiguration>(entity =>
            {
                entity.Property(e => e.ConfigurationTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Decisionloc>(entity =>
            {
                entity.HasKey(e => new { e.DecisionId, e.LocationId });
            });

            modelBuilder.Entity<Decperiod>(entity =>
            {
                entity.Property(e => e.Complete).IsUnicode(false);

                entity.Property(e => e.Submitted).IsUnicode(false);
            });

            modelBuilder.Entity<Deliverable>(entity =>
            {
                entity.Property(e => e.ExternalId).IsUnicode(false);
            });

            modelBuilder.Entity<DiversityClassification>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);
            });

            modelBuilder.Entity<Emailflow>(entity =>
            {
                entity.Property(e => e.TooltmplId).ValueGeneratedNever();

                entity.Property(e => e.CloseIsHtmlEmail).IsUnicode(false);

                entity.Property(e => e.FinalIsHtmlEmail).IsUnicode(false);

                entity.Property(e => e.InitialIsHtmlEmail).IsUnicode(false);

                entity.Property(e => e.ReminderIsHtmlEmail).IsUnicode(false);

                entity.Property(e => e.UseCloseEmail).IsUnicode(false);

                entity.Property(e => e.UseFinalEmail).IsUnicode(false);

                entity.Property(e => e.UseReminderEmail).IsUnicode(false);
            });

            modelBuilder.Entity<EmailTemp>(entity =>
            {
                entity.HasKey(e => new { e.TooltmplId, e.CustpersId });

                entity.Property(e => e.FromName).IsUnicode(false);

                entity.Property(e => e.IsHtmlEmail).IsUnicode(false);

                entity.Property(e => e.LastEmailStatus).IsUnicode(false);

                entity.Property(e => e.ThisEmailStatus).IsUnicode(false);

                entity.Property(e => e.ToFirstName).IsUnicode(false);

                entity.Property(e => e.ToName).IsUnicode(false);
            });

            modelBuilder.Entity<Emailtmpl>(entity =>
            {
                entity.Property(e => e.IsHtmlEmail).IsUnicode(false);

                entity.Property(e => e.Module).IsUnicode(false);
            });

            modelBuilder.Entity<EntityAccess>(entity =>
            {
                entity.Property(e => e.AccessLevel).IsUnicode(false);

                entity.Property(e => e.ApplicationId).IsUnicode(false);

                entity.Property(e => e.ApplicationTypeId).IsUnicode(false);

                entity.Property(e => e.EntityTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<EntityAuditLog>(entity =>
            {
                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.UserType).IsUnicode(false);
            });

            modelBuilder.Entity<EntityAuditLogDetail>(entity =>
            {
                entity.Property(e => e.FieldName).IsUnicode(false);
            });

            modelBuilder.Entity<EntityAuditLogType>(entity =>
            {
                entity.Property(e => e.GroupName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<EntityWorkflowHistory>(entity =>
            {
                entity.Property(e => e.ActionId).IsUnicode(false);

                entity.Property(e => e.UserTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<Errorlog>(entity =>
            {
                entity.Property(e => e.ApplicationId).IsUnicode(false);

                entity.Property(e => e.Component).IsUnicode(false);

                entity.Property(e => e.ErrorDesc).IsUnicode(false);

                entity.Property(e => e.ErrorField).IsUnicode(false);

                entity.Property(e => e.ErrorStatus).IsUnicode(false);

                entity.Property(e => e.PageName).IsUnicode(false);
            });

            modelBuilder.Entity<Evaluatorgroup>(entity =>
            {
                entity.Property(e => e.Active).IsUnicode(false);

                entity.Property(e => e.EvaluatorgroupShort).IsUnicode(false);
            });

            modelBuilder.Entity<Facmst>(entity =>
            {
                entity.Property(e => e.EvidenceDesc).IsUnicode(false);

                entity.Property(e => e.FacmstDesc).IsUnicode(false);

                entity.Property(e => e.FacmstShort).IsUnicode(false);
            });

            modelBuilder.Entity<Facmstm>(entity =>
            {
                entity.HasKey(e => new { e.FacmstId, e.MeasureOrder });

                entity.Property(e => e.MeasureShort).IsUnicode(false);
            });

            modelBuilder.Entity<Factmpldw>(entity =>
            {
                entity.HasKey(e => new { e.DecisionId, e.FactmplId });
            });

            modelBuilder.Entity<Factormst>(entity =>
            {
                entity.Property(e => e.FactormstDesc).IsUnicode(false);

                entity.Property(e => e.FactormstShort).IsUnicode(false);

                entity.Property(e => e.FactormstType).IsUnicode(false);

                entity.Property(e => e.FactormstUnit).IsUnicode(false);

                entity.Property(e => e.UseQuant).IsUnicode(false);
            });

            modelBuilder.Entity<Factscale>(entity =>
            {
                entity.Property(e => e.Frequency).IsUnicode(false);
            });

            modelBuilder.Entity<Factscalem>(entity =>
            {
                entity.HasKey(e => new { e.FactscaleId, e.MeasureOrder });
            });

            modelBuilder.Entity<Function>(entity =>
            {
                entity.Property(e => e.ExternalId).IsUnicode(false);
            });

            modelBuilder.Entity<Initiative>(entity =>
            {
                entity.Property(e => e.ExternalId).IsUnicode(false);
            });

            modelBuilder.Entity<JobBase>(entity =>
            {
                entity.Property(e => e.BidStatus).IsUnicode(false);
            });

            modelBuilder.Entity<JobCostElement>(entity =>
            {
                entity.Property(e => e.CostPartyTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<Jobfunction>(entity =>
            {
                entity.Property(e => e.Active).IsUnicode(false);

                entity.Property(e => e.JobfunctionShort).IsUnicode(false);
            });

            modelBuilder.Entity<KnowledgeCommentTag>(entity =>
            {
                entity.HasKey(e => new { e.KnowledgeCommentId, e.KnowledgeTagId });
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Active).IsUnicode(false);

                entity.Property(e => e.LocationShort).IsUnicode(false);
            });

            modelBuilder.Entity<Org>(entity =>
            {
                entity.Property(e => e.AcctypePlLang).IsUnicode(false);

                entity.Property(e => e.Active).IsUnicode(false);

                entity.Property(e => e.AllowCrossAgency).IsUnicode(false);

                entity.Property(e => e.AssesstypeLevel).IsUnicode(false);

                entity.Property(e => e.CanCreate).IsUnicode(false);

                entity.Property(e => e.CanUncomplete).IsUnicode(false);

                entity.Property(e => e.ClientSupplier).IsUnicode(false);

                entity.Property(e => e.CollectPharmaData).IsUnicode(false);

                entity.Property(e => e.DecisionPlLang).IsUnicode(false);

                entity.Property(e => e.EvaluationType).IsUnicode(false);

                entity.Property(e => e.OrgName).IsUnicode(false);

                entity.Property(e => e.OrgReference).IsUnicode(false);

                entity.Property(e => e.OrgunitPlLang).IsUnicode(false);

                entity.Property(e => e.OwnerReopenReviewAction).IsUnicode(false);

                entity.Property(e => e.Priority).IsUnicode(false);

                entity.Property(e => e.ShareReviewReports).IsUnicode(false);

                entity.Property(e => e.ShowFactormstShort).IsUnicode(false);

                entity.Property(e => e.UseAcctype).IsUnicode(false);

                entity.Property(e => e.UseActionPlan).IsUnicode(false);

                entity.Property(e => e.UseAgencyDetails).IsUnicode(false);

                entity.Property(e => e.UseAssesstype).IsUnicode(false);

                entity.Property(e => e.UseAutoEmail).IsUnicode(false);

                entity.Property(e => e.UseBriefing).IsUnicode(false);

                entity.Property(e => e.UseCustorgunit).IsUnicode(false);

                entity.Property(e => e.UseDashboard).IsUnicode(false);

                entity.Property(e => e.UseDecperiod).IsUnicode(false);

                entity.Property(e => e.UseEvaluation).IsUnicode(false);

                entity.Property(e => e.UseEvaluatorgroup).IsUnicode(false);

                entity.Property(e => e.UseFactmpldw).IsUnicode(false);

                entity.Property(e => e.UseGeography).IsUnicode(false);

                entity.Property(e => e.UseGlobalReport).IsUnicode(false);

                entity.Property(e => e.UseJobfunction).IsUnicode(false);

                entity.Property(e => e.UseKnowledgeBase).IsUnicode(false);

                entity.Property(e => e.UseLocation).IsUnicode(false);

                entity.Property(e => e.UseMinorityVendor).IsUnicode(false);

                entity.Property(e => e.UseOnwatch).IsUnicode(false);

                entity.Property(e => e.UseOnwatchAuto).IsUnicode(false);

                entity.Property(e => e.UseOwnerOverride).IsUnicode(false);

                entity.Property(e => e.UseOwnerReopenReview).IsUnicode(false);

                entity.Property(e => e.UsePriority).IsUnicode(false);

                entity.Property(e => e.UseProduction).IsUnicode(false);

                entity.Property(e => e.UsePromoter).IsUnicode(false);

                entity.Property(e => e.UseQuantMeasure).IsUnicode(false);

                entity.Property(e => e.UseReviewDates).IsUnicode(false);

                entity.Property(e => e.UseRoster).IsUnicode(false);

                entity.Property(e => e.UseSegment).IsUnicode(false);

                entity.Property(e => e.UseSignExternal).IsUnicode(false);

                entity.Property(e => e.UseSignatory).IsUnicode(false);

                entity.Property(e => e.UseSow).IsUnicode(false);

                entity.Property(e => e.UseSso).IsUnicode(false);

                entity.Property(e => e.UseSubacctype).IsUnicode(false);

                entity.Property(e => e.UseSubmitDate).IsUnicode(false);

                entity.Property(e => e.UseSustainability).IsUnicode(false);
            });

            modelBuilder.Entity<OrganizationApplicationFeature>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.ApplicationFeatureId });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PasswordHistory>(entity =>
            {
                entity.Property(e => e.UserType).IsUnicode(false);
            });

            modelBuilder.Entity<PlatformEmailJob>(entity =>
            {
                entity.Property(e => e.AdminMessageTemplate).IsUnicode(false);

                entity.Property(e => e.ApplicationUserTypeId).IsUnicode(false);

                entity.Property(e => e.EmailSubject).IsUnicode(false);

                entity.Property(e => e.EntityUserTypeId).IsUnicode(false);

                entity.Property(e => e.UserMessageTemplate).IsUnicode(false);
            });

            modelBuilder.Entity<PlatformEmailNotification>(entity =>
            {
                entity.Property(e => e.CrossAgencyAccessStatusId).IsUnicode(false);

                entity.Property(e => e.OrgName).IsUnicode(false);

                entity.Property(e => e.OrgReference).IsUnicode(false);

                entity.Property(e => e.UserFirstName).IsUnicode(false);

                entity.Property(e => e.UserLastName).IsUnicode(false);

                entity.Property(e => e.UserTypeId).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<PlatformEmailRun>(entity =>
            {
                entity.Property(e => e.RunTypeId).IsUnicode(false);

                entity.Property(e => e.StatusId).IsUnicode(false);
            });

            modelBuilder.Entity<ProductionConfiguration>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Quesmst>(entity =>
            {
                entity.Property(e => e.DisplayAcross).IsUnicode(false);

                entity.Property(e => e.GapAfter).IsUnicode(false);

                entity.Property(e => e.GapBefore).IsUnicode(false);

                entity.Property(e => e.HeaderDesc).IsUnicode(false);

                entity.Property(e => e.InputType).IsUnicode(false);

                entity.Property(e => e.QuesmstDesc).IsUnicode(false);

                entity.Property(e => e.QuesmstShort).IsUnicode(false);

                entity.Property(e => e.RequiredField).IsUnicode(false);
            });

            modelBuilder.Entity<RateCardRole>(entity =>
            {
                entity.Property(e => e.BillingTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<ReconciliationPeriod>(entity =>
            {
                entity.Property(e => e.FrequencyId).IsUnicode(false);

                entity.Property(e => e.QuarterId).IsUnicode(false);
            });

            modelBuilder.Entity<Repacctype>(entity =>
            {
                entity.Property(e => e.AcctypeId).ValueGeneratedNever();

                entity.Property(e => e.AcctypeShort).IsUnicode(false);
            });

            modelBuilder.Entity<Repcustorgunit>(entity =>
            {
                entity.Property(e => e.CustorgunitId).ValueGeneratedNever();

                entity.Property(e => e.CustorgunitHiddenorder).IsUnicode(false);

                entity.Property(e => e.CustorgunitName1).IsUnicode(false);

                entity.Property(e => e.CustorgunitName2).IsUnicode(false);

                entity.Property(e => e.CustorgunitName3).IsUnicode(false);
            });

            modelBuilder.Entity<Repfactdec>(entity =>
            {
                entity.Property(e => e.AccountShort).IsUnicode(false);

                entity.Property(e => e.CustorgName).IsUnicode(false);

                entity.Property(e => e.IntExt).IsUnicode(false);
            });

            modelBuilder.Entity<Repgeography>(entity =>
            {
                entity.Property(e => e.GeographyId).ValueGeneratedNever();

                entity.Property(e => e.GeographyHiddenorder).IsUnicode(false);

                entity.Property(e => e.GeographyName1).IsUnicode(false);

                entity.Property(e => e.GeographyName2).IsUnicode(false);

                entity.Property(e => e.GeographyName3).IsUnicode(false);
            });

            modelBuilder.Entity<Reporgunit>(entity =>
            {
                entity.Property(e => e.OrgunitId).ValueGeneratedNever();

                entity.Property(e => e.OrgunitHiddenorder).IsUnicode(false);

                entity.Property(e => e.OrgunitName1).IsUnicode(false);

                entity.Property(e => e.OrgunitName2).IsUnicode(false);

                entity.Property(e => e.OrgunitName3).IsUnicode(false);

                entity.Property(e => e.OrgunitName4).IsUnicode(false);
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.ArchiveFile).IsUnicode(false);

                entity.Property(e => e.CrystalName).IsUnicode(false);

                entity.Property(e => e.DataSource).IsUnicode(false);

                entity.Property(e => e.DataSourceType).IsUnicode(false);

                entity.Property(e => e.DatabaseName).IsUnicode(false);

                entity.Property(e => e.ReportDesc).IsUnicode(false);

                entity.Property(e => e.RunBy).IsUnicode(false);

                entity.Property(e => e.ViewerType).IsUnicode(false);
            });

            modelBuilder.Entity<Reportbatch>(entity =>
            {
                entity.Property(e => e.StatusId).IsUnicode(false);
            });

            modelBuilder.Entity<Reportcolumn>(entity =>
            {
                entity.Property(e => e.ReportcolumnAlias).IsUnicode(false);

                entity.Property(e => e.ReportcolumnName).IsUnicode(false);
            });

            modelBuilder.Entity<Reportconfig>(entity =>
            {
                entity.Property(e => e.TooltmplId).ValueGeneratedNever();

                entity.Property(e => e.InclAssessmentInConsolidation).IsUnicode(false);

                entity.Property(e => e.InclAssessmentInExecsummary).IsUnicode(false);

                entity.Property(e => e.InclBenchmarkInConsolidation).IsUnicode(false);

                entity.Property(e => e.InclBenchmarkInExecsummary).IsUnicode(false);

                entity.Property(e => e.InclCommentsInConsolidation).IsUnicode(false);

                entity.Property(e => e.InclCommentsInExecsummary).IsUnicode(false);

                entity.Property(e => e.InclEvaluatorgroupcrosstabInConsolidation).IsUnicode(false);

                entity.Property(e => e.InclEvaluatorgroupcrosstabInExecsummary).IsUnicode(false);

                entity.Property(e => e.InclGapInConsolidation).IsUnicode(false);

                entity.Property(e => e.InclGapInExecsummary).IsUnicode(false);

                entity.Property(e => e.InclIndividualcrosstabInConsolidation).IsUnicode(false);

                entity.Property(e => e.InclIndividualcrosstabInExecsummary).IsUnicode(false);

                entity.Property(e => e.InclJobfunctioncrosstabInConsolidation).IsUnicode(false);

                entity.Property(e => e.InclJobfunctioncrosstabInExecsummary).IsUnicode(false);

                entity.Property(e => e.InclLocationcrosstabInConsolidation).IsUnicode(false);

                entity.Property(e => e.InclLocationcrosstabInExecsummary).IsUnicode(false);

                entity.Property(e => e.InclTrendInConsolidation).IsUnicode(false);

                entity.Property(e => e.InclTrendInExecsummary).IsUnicode(false);
            });

            modelBuilder.Entity<Reportparam>(entity =>
            {
                entity.Property(e => e.Dataname).IsUnicode(false);

                entity.Property(e => e.Datatype).IsUnicode(false);

                entity.Property(e => e.Datavalue).IsUnicode(false);
            });

            modelBuilder.Entity<Repsegment>(entity =>
            {
                entity.Property(e => e.SegmentId).ValueGeneratedNever();

                entity.Property(e => e.SegmentName).IsUnicode(false);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(e => e.BillingTypeId).IsUnicode(false);

                entity.Property(e => e.ExternalId).IsUnicode(false);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.Frequency).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.Weighting).IsUnicode(false);
            });

            modelBuilder.Entity<Rfactmpl>(entity =>
            {
                entity.Property(e => e.EvidenceDesc).IsUnicode(false);

                entity.Property(e => e.ExternalAttatchFlag).IsUnicode(false);

                entity.Property(e => e.ExternalCommentFlag).IsUnicode(false);

                entity.Property(e => e.ExternalDesc).IsUnicode(false);

                entity.Property(e => e.ExternalType).IsUnicode(false);

                entity.Property(e => e.Filename).IsUnicode(false);

                entity.Property(e => e.Filesize).IsUnicode(false);

                entity.Property(e => e.Filetype).IsUnicode(false);

                entity.Property(e => e.RfactmplDesc).IsUnicode(false);

                entity.Property(e => e.RfactmplHiddenorder).IsUnicode(false);

                entity.Property(e => e.RfactmplLevelorder).IsUnicode(false);

                entity.Property(e => e.RfactmplShort).IsUnicode(false);
            });

            modelBuilder.Entity<ScopeBase>(entity =>
            {
                entity.Property(e => e.ContractAddress).IsUnicode(false);

                entity.Property(e => e.ContractHolding).IsUnicode(false);

                entity.Property(e => e.Duration).IsUnicode(false);

                entity.Property(e => e.FeeTypeId).IsUnicode(false);

                entity.Property(e => e.ReconciliationFrequencyId).IsUnicode(false);
            });

            modelBuilder.Entity<Scorecarddoc>(entity =>
            {
                entity.Property(e => e.ClientDeclined).IsUnicode(false);

                entity.Property(e => e.ClientDocName).IsUnicode(false);

                entity.Property(e => e.ClientDocSize).IsUnicode(false);

                entity.Property(e => e.ClientDocType).IsUnicode(false);

                entity.Property(e => e.SupplierDeclined).IsUnicode(false);

                entity.Property(e => e.SupplierDocName).IsUnicode(false);

                entity.Property(e => e.SupplierDocSize).IsUnicode(false);

                entity.Property(e => e.SupplierDocType).IsUnicode(false);
            });

            modelBuilder.Entity<Segment>(entity =>
            {
                entity.Property(e => e.SegmentName).IsUnicode(false);
            });

            modelBuilder.Entity<ServiceServiceSegment>(entity =>
            {
                entity.HasKey(e => new { e.ServiceId, e.ServiceSegmentId });
            });

            modelBuilder.Entity<Signature>(entity =>
            {
                entity.HasKey(e => new { e.DecisionId, e.CustpersId });

                entity.Property(e => e.Complete).IsUnicode(false);

                entity.Property(e => e.SignatureType).IsUnicode(false);
            });

            modelBuilder.Entity<SowConfiguration>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<SowEmailJob>(entity =>
            {
                entity.Property(e => e.AdminMessageTemplate).IsUnicode(false);

                entity.Property(e => e.ApplicationUserTypeId).IsUnicode(false);

                entity.Property(e => e.EmailSubject).IsUnicode(false);

                entity.Property(e => e.ScopeUserTypeId).IsUnicode(false);

                entity.Property(e => e.UserMessageTemplate).IsUnicode(false);
            });

            modelBuilder.Entity<SowEmailNotification>(entity =>
            {
                entity.Property(e => e.OrgName).IsUnicode(false);

                entity.Property(e => e.OrgReference).IsUnicode(false);

                entity.Property(e => e.UserFirstName).IsUnicode(false);

                entity.Property(e => e.UserLastName).IsUnicode(false);

                entity.Property(e => e.UserTypeId).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);
            });

            modelBuilder.Entity<SowEmailRun>(entity =>
            {
                entity.Property(e => e.RunTypeId).IsUnicode(false);

                entity.Property(e => e.StatusId).IsUnicode(false);
            });

            modelBuilder.Entity<SsoProfile>(entity =>
            {
                entity.Property(e => e.AlternateCertificateFileName).IsUnicode(false);

                entity.Property(e => e.CertificateFileName).IsUnicode(false);

                entity.Property(e => e.Environment).IsUnicode(false);

                entity.Property(e => e.IdpAdminSsoTargetUrl).IsUnicode(false);

                entity.Property(e => e.IdpStandardSsoTargetUrl).IsUnicode(false);

                entity.Property(e => e.IdpXpathToEmail).IsUnicode(false);

                entity.Property(e => e.IdpXpathToFirstName).IsUnicode(false);

                entity.Property(e => e.IdpXpathToSurName).IsUnicode(false);

                entity.Property(e => e.IdpXpathToUserGroup).IsUnicode(false);

                entity.Property(e => e.NameIdFormat).IsUnicode(false);

                entity.Property(e => e.ProtocolBinding).IsUnicode(false);

                entity.Property(e => e.SpadminAssertionConsumerServiceUrl).IsUnicode(false);

                entity.Property(e => e.Spissuer).IsUnicode(false);

                entity.Property(e => e.SpissuerStandard).IsUnicode(false);

                entity.Property(e => e.SpstandardAssertionConsumerServiceUrl).IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.StatusShort).IsUnicode(false);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.AccountLocked).IsUnicode(false);

                entity.Property(e => e.Active).IsUnicode(false);

                entity.Property(e => e.AreaCovered).IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Complete).IsUnicode(false);

                entity.Property(e => e.ExternalComplete).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.KeyContactFirstName).IsUnicode(false);

                entity.Property(e => e.KeyContactPhone).IsUnicode(false);

                entity.Property(e => e.KeyContactSurname).IsUnicode(false);

                entity.Property(e => e.LegalName).IsUnicode(false);

                entity.Property(e => e.MinorityOwnedDesc).IsUnicode(false);

                entity.Property(e => e.Mobile).IsUnicode(false);

                entity.Property(e => e.NoOfDirector).IsUnicode(false);

                entity.Property(e => e.NoOfEmployee).IsUnicode(false);

                entity.Property(e => e.NoOfWriter).IsUnicode(false);

                entity.Property(e => e.ParentCompany).IsUnicode(false);

                entity.Property(e => e.PasswordIsOtp).IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.Property(e => e.RegionalHub).IsUnicode(false);

                entity.Property(e => e.Salt).IsUnicode(false);

                entity.Property(e => e.Surname).IsUnicode(false);

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.TradingName).IsUnicode(false);

                entity.Property(e => e.Website).IsUnicode(false);
            });

            modelBuilder.Entity<Teamspecr>(entity =>
            {
                entity.HasKey(e => new { e.TeamId, e.SpecialtyId });

                entity.Property(e => e.Comment).IsUnicode(false);
            });

            modelBuilder.Entity<TripleBid>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<WorkflowHistory>(entity =>
            {
                entity.Property(e => e.ActionId).IsUnicode(false);

                entity.Property(e => e.UserTypeId).IsUnicode(false);
            });

            modelBuilder.Entity<WorkflowStep>(entity =>
            {
                entity.Property(e => e.UserTypeId).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
