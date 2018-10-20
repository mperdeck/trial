using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("DeliverableRateCardDeliverable")]
    public partial class DeliverableRateCardDeliverable
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int DeliverableRateCardId { get; set; }
        public int AgencyDeliverableId { get; set; }
        [Column(TypeName = "money")]
        public decimal Fee { get; set; }
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
