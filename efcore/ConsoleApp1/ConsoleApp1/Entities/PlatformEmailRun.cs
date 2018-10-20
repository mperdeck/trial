using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("PlatformEmailRun")]
    public partial class PlatformEmailRun
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        [Required]
        [StringLength(60)]
        public string UserFullName { get; set; }
        [Required]
        [StringLength(2)]
        public string RunTypeId { get; set; }
        [Required]
        [StringLength(2)]
        public string StatusId { get; set; }
        public int TotalNotificationsSent { get; set; }
        public string Details { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RunDate { get; set; }
    }
}
