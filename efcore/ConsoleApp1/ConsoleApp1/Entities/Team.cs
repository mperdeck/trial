using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("team")]
    public partial class Team
    {
        [Column("team_id")]
        public int TeamId { get; set; }
        [Column("org_id")]
        public int? OrgId { get; set; }
        [Column("geography_id")]
        public int GeographyId { get; set; }
        [Column("first_name")]
        [StringLength(15)]
        public string FirstName { get; set; }
        [Column("surname")]
        [StringLength(20)]
        public string Surname { get; set; }
        [Column("title")]
        [StringLength(50)]
        public string Title { get; set; }
        [Column("phone")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Column("mobile")]
        [StringLength(20)]
        public string Mobile { get; set; }
        [Column("email")]
        [StringLength(80)]
        public string Email { get; set; }
        [Column("website")]
        [StringLength(100)]
        public string Website { get; set; }
        [Column("year_founded")]
        public short? YearFounded { get; set; }
        [Column("total_revenue")]
        public double? TotalRevenue { get; set; }
        [Column("client_revenue")]
        public double? ClientRevenue { get; set; }
        [Column("pharma_revenue")]
        public double? PharmaRevenue { get; set; }
        [Column("prior_year_total_revenue")]
        public double? PriorYearTotalRevenue { get; set; }
        [Column("prior_year_client_revenue")]
        public double? PriorYearClientRevenue { get; set; }
        [Column("prior_year_pharma_revenue")]
        public double? PriorYearPharmaRevenue { get; set; }
        [Column("last_email_date", TypeName = "datetime")]
        public DateTime? LastEmailDate { get; set; }
        [Column("status_id")]
        public int? StatusId { get; set; }
        [Column("value_category")]
        public int? ValueCategory { get; set; }
        [Column("complete")]
        [StringLength(1)]
        public string Complete { get; set; }
        [Column("complete_date", TypeName = "datetime")]
        public DateTime? CompleteDate { get; set; }
        [Column("external_complete")]
        [StringLength(1)]
        public string ExternalComplete { get; set; }
        [Column("external_complete_date", TypeName = "datetime")]
        public DateTime? ExternalCompleteDate { get; set; }
        [Column("comment")]
        [StringLength(2000)]
        public string Comment { get; set; }
        [Column("parent_company")]
        [StringLength(50)]
        public string ParentCompany { get; set; }
        [Column("trading_name")]
        [StringLength(50)]
        public string TradingName { get; set; }
        [Column("no_of_employee")]
        [StringLength(50)]
        public string NoOfEmployee { get; set; }
        [Column("key_contact_first_name")]
        [StringLength(15)]
        public string KeyContactFirstName { get; set; }
        [Column("key_contact_surname")]
        [StringLength(20)]
        public string KeyContactSurname { get; set; }
        [Column("key_contact_phone")]
        [StringLength(80)]
        public string KeyContactPhone { get; set; }
        [Column("key_contact_email")]
        [StringLength(80)]
        public string KeyContactEmail { get; set; }
        [Column("start_date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("termination_date", TypeName = "datetime")]
        public DateTime? TerminationDate { get; set; }
        [Column("minority_owned_desc")]
        [StringLength(500)]
        public string MinorityOwnedDesc { get; set; }
        [Column("no_of_director")]
        [StringLength(50)]
        public string NoOfDirector { get; set; }
        [Column("no_of_writer")]
        [StringLength(50)]
        public string NoOfWriter { get; set; }
        [Column("regional_hub")]
        [StringLength(1)]
        public string RegionalHub { get; set; }
        [Column("area_covered")]
        [StringLength(500)]
        public string AreaCovered { get; set; }
        [Column("login_attempts")]
        public short? LoginAttempts { get; set; }
        [Column("account_locked")]
        [StringLength(1)]
        public string AccountLocked { get; set; }
        [Column("active")]
        [StringLength(1)]
        public string Active { get; set; }
        [Column("creation_date", TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Column("team_ext")]
        public Guid? TeamExt { get; set; }
        [Column("person_id")]
        public int? PersonId { get; set; }
        [Column("hash_password")]
        [MaxLength(64)]
        public byte[] HashPassword { get; set; }
        [Column("alternate_password")]
        [MaxLength(64)]
        public byte[] AlternatePassword { get; set; }
        [Column("password_is_otp")]
        [StringLength(1)]
        public string PasswordIsOtp { get; set; }
        [Column("password_change_date", TypeName = "datetime")]
        public DateTime? PasswordChangeDate { get; set; }
        [Column("legal_name")]
        [StringLength(50)]
        public string LegalName { get; set; }
        [Column("hash256_password")]
        [MaxLength(64)]
        public byte[] Hash256Password { get; set; }
        [Column("salt")]
        [StringLength(8)]
        public string Salt { get; set; }
        [Column("alternate_password_change_date", TypeName = "datetime")]
        public DateTime? AlternatePasswordChangeDate { get; set; }
        [Column("team_guid")]
        public Guid TeamGuid { get; set; }
        [Column("client_diversity_classification_id")]
        public int? ClientDiversityClassificationId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [StringLength(150)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateLastUpdated { get; set; }
        [StringLength(150)]
        public string LastUpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLogInDate { get; set; }
    }
}
