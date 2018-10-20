using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ASPStateTempApplications")]
    public partial class AspstateTempApplication
    {
        [Key]
        public int AppId { get; set; }
        [Required]
        [StringLength(280)]
        public string AppName { get; set; }
    }
}
