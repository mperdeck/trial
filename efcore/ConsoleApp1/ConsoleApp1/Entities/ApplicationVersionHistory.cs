using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ApplicationVersionHistory")]
    public partial class ApplicationVersionHistory
    {
        public int Id { get; set; }
        [Required]
        [StringLength(5)]
        public string ApplicationId { get; set; }
        [Required]
        [StringLength(200)]
        public string Version { get; set; }
        public int UpgradeStep { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateUpdated { get; set; }
    }
}
