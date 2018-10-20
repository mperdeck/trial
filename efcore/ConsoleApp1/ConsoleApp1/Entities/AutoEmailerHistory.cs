using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("AutoEmailerHistory")]
    public partial class AutoEmailerHistory
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string JobId { get; set; }
        public int UserId { get; set; }
        [Required]
        [StringLength(15)]
        public string UserFirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string UserLastName { get; set; }
        [Required]
        [StringLength(2)]
        public string UserType { get; set; }
        [Required]
        [StringLength(80)]
        public string UserEmailAddress { get; set; }
        [Required]
        [StringLength(80)]
        public string Username { get; set; }
        public int ClientId { get; set; }
        [Required]
        [StringLength(10)]
        public string OrgReference { get; set; }
        [Required]
        [StringLength(50)]
        public string OrgName { get; set; }
        [Required]
        [StringLength(6)]
        public string SentStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateSent { get; set; }
    }
}
