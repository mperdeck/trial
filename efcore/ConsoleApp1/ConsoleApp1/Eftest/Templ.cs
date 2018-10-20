using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Eftest
{
[Table("templ")]
    public partial class Templ
    {
        public int Id { get; set; }
        [Column("templname")]
        [StringLength(10)]
        public string Templname { get; set; }
        public int ClientId { get; set; }


            [ForeignKey("ClientId")]
            [InverseProperty("Templs")]
                public Client Client { get; set; }
    }
}
