using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ClientCurrency")]
    public partial class ClientCurrency
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int ClientId { get; set; }
        public int SortOrdinal { get; set; }
        public int? CurrencyId { get; set; }
        [Column(TypeName = "decimal(19, 9)")]
        public decimal? ExchangeRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExchangeRateAsAt { get; set; }
        public bool IsBaseCurrency { get; set; }
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
