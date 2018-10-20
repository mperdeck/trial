using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Eftest
{
[Table("templ2")]
    public partial class Templ2
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        [Column("templ2name")]
        [StringLength(10)]
        public string Templ2name { get; set; }


            [ForeignKey("ClientId")]
            [InverseProperty("Templ2Client")]
                public Client Client { get; set; }
            [ForeignKey("Id")]
            [InverseProperty("Templ2IdNavigation")]
                public Client IdNavigation { get; set; }
    }
}
