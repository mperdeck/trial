using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("PasswordHistory")]
    public partial class PasswordHistory
    {
        public int UserId { get; set; }
        [Required]
        [StringLength(2)]
        public string UserType { get; set; }
        [Required]
        [MaxLength(64)]
        public byte[] PasswordHash { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DatePasswordWasSet { get; set; }
        public int Id { get; set; }
    }
}
