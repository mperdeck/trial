using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("JobBase")]
    public partial class JobBase
    {
        public int Id { get; set; }
        public int? CentralDocumentId { get; set; }
        public int? ParentId { get; set; }
        public int? LeadUserId { get; set; }
        public int? ProductionHouseId { get; set; }
        public int? ProductionLeadId { get; set; }
        public int? RowIndex { get; set; }
        [StringLength(1)]
        public string BidStatus { get; set; }
        public bool IsTripleBid { get; set; }
        public bool IsSelectedBid { get; set; }
        [Required]
        [StringLength(20)]
        public string JobModelTypeId { get; set; }
        public int? PrimaryScopeId { get; set; }
        public int? CostTemplateId { get; set; }
        [StringLength(20)]
        public string JobCostTypeId { get; set; }
        public bool? CollectActualsCost { get; set; }
        public int? UpfrontPayment { get; set; }
        public int? EstimateWorkflowId { get; set; }
        public int? ActualsWorkflowId { get; set; }
        [StringLength(50)]
        public string JobNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? JobStartDate { get; set; }
        [StringLength(1000)]
        public string Locations { get; set; }
        public int? TotalShootDays { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LocationDateStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LocationDateEnd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EstimateFirstInMarketDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActualFirstInMarketDate { get; set; }
        public int? ShootTypeId { get; set; }
        public int? ProductionTypeId { get; set; }
        public string Comment { get; set; }
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
        public Guid ExtId { get; set; }
    }
}
