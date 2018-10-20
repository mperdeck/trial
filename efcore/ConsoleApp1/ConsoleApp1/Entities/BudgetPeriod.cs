﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("BudgetPeriod")]
    public partial class BudgetPeriod
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int ClientId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PeriodStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PeriodEnd { get; set; }
        [StringLength(20)]
        public string ApplicationId { get; set; }
        public int SortOrdinal { get; set; }
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
        public bool IsActive { get; set; }
    }
}
