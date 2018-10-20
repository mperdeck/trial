using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("DecidewareConfiguration")]
    public partial class DecidewareConfiguration
    {
        [Key]
        [StringLength(10)]
        public string ConfigurationTypeId { get; set; }
        public bool IsLocked { get; set; }
    }
}
