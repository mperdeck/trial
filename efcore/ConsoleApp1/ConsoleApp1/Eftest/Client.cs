using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Eftest
{
[Table("Client")]
    public partial class Client
    {
        public Client()
        {
            ClientSuppliers = new HashSet<ClientSupplier>();
            People = new HashSet<Person>();
            Templ2Client = new HashSet<Templ2>();
            Templs = new HashSet<Templ>();
        }

        public int Id { get; set; }
        [StringLength(100)]
        public string ClientName { get; set; }
        [Column("country_id")]
        public int? CountryId { get; set; }


            [ForeignKey("CountryId")]
            [InverseProperty("Clients")]
                public Country Country { get; set; }
            [InverseProperty("IdNavigation")]
                public Templ2 Templ2IdNavigation { get; set; }
            [InverseProperty("Client")]
            public ICollection<ClientSupplier> ClientSuppliers { get; set; }
            [InverseProperty("MyClient")]
            public ICollection<Person> People { get; set; }
            [InverseProperty("Client")]
            public ICollection<Templ2> Templ2Client { get; set; }
            [InverseProperty("Client")]
            public ICollection<Templ> Templs { get; set; }
    }
}
