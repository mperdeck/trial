using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("RateCardRole")]
    public partial class RateCardRole
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int RateCardId { get; set; }
        public int AgencyRoleId { get; set; }
        [Column(TypeName = "decimal(28, 15)")]
        public decimal Rate { get; set; }
        [Required]
        [StringLength(2)]
        public string BillingTypeId { get; set; }
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
    }
}
