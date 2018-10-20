using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("SsoProfile")]
    public partial class SsoProfile
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        [Required]
        [StringLength(5)]
        public string Environment { get; set; }
        public bool EnforceSso { get; set; }
        public bool OrgUserProvisioningAdmin { get; set; }
        public bool OrgUserProvisioningStandard { get; set; }
        public byte OrgEvaluationProvisioningLevel { get; set; }
        public byte OrgCapabilityProvisioningLevel { get; set; }
        public byte OrgSowProvisioningLevel { get; set; }
        [StringLength(1000)]
        public string OrgAdminContactDetails { get; set; }
        public short OrgServerTimeOffsetInSeconds { get; set; }
        [StringLength(200)]
        public string IdpAdminGroupName { get; set; }
        [StringLength(200)]
        public string IdpStandardGroupName { get; set; }
        [Required]
        [StringLength(500)]
        public string IdpAdminSsoTargetUrl { get; set; }
        [Required]
        [StringLength(500)]
        public string IdpStandardSsoTargetUrl { get; set; }
        [Required]
        [Column("IdpXPathToEmail")]
        [StringLength(500)]
        public string IdpXpathToEmail { get; set; }
        [Required]
        [Column("IdpXPathToFirstName")]
        [StringLength(500)]
        public string IdpXpathToFirstName { get; set; }
        [Required]
        [Column("IdpXPathToSurName")]
        [StringLength(500)]
        public string IdpXpathToSurName { get; set; }
        [Column("IdpXPathToUserGroup")]
        [StringLength(500)]
        public string IdpXpathToUserGroup { get; set; }
        [Required]
        [Column("SPIssuer")]
        [StringLength(200)]
        public string Spissuer { get; set; }
        [Required]
        [Column("SPAdminAssertionConsumerServiceUrl")]
        [StringLength(500)]
        public string SpadminAssertionConsumerServiceUrl { get; set; }
        [Required]
        [Column("SPStandardAssertionConsumerServiceUrl")]
        [StringLength(500)]
        public string SpstandardAssertionConsumerServiceUrl { get; set; }
        [StringLength(100)]
        public string CertificateFileName { get; set; }
        [Column(TypeName = "image")]
        public byte[] CertificateContent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CertificateExpiryDate { get; set; }
        [StringLength(100)]
        public string AlternateCertificateFileName { get; set; }
        [Column(TypeName = "image")]
        public byte[] AlternateCertificateContent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AlternateCertificateExpiryDate { get; set; }
        [Required]
        [Column("SPIssuerStandard")]
        [StringLength(200)]
        public string SpissuerStandard { get; set; }
        public bool ForceAuthn { get; set; }
        public bool IsPassive { get; set; }
        [Required]
        [StringLength(100)]
        public string ProtocolBinding { get; set; }
        [Required]
        [StringLength(200)]
        public string NameIdFormat { get; set; }
    }
}
