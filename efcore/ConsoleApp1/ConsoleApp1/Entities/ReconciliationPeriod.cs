﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ReconciliationPeriod")]
    public partial class ReconciliationPeriod
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int ScopePeriodId { get; set; }
        [Required]
        [StringLength(2)]
        public string QuarterId { get; set; }
        [Required]
        [StringLength(1)]
        public string FrequencyId { get; set; }
        public int StartPeriodId { get; set; }
        public int EndPeriodId { get; set; }
        public int Sequence { get; set; }
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
        public bool IsActive { get; set; }
    }
}
