using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Eftest
{
[Table("Person")]
    public partial class Person
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Surname { get; set; }
        [Column("my_client_id")]
        public int? MyClientId { get; set; }


            [ForeignKey("MyClientId")]
            [InverseProperty("People")]
                public Client MyClient { get; set; }
    }
}
