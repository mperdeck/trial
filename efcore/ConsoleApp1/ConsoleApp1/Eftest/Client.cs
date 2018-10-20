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
        }

        public int Id { get; set; }
        [StringLength(100)]
        public string ClientName { get; set; }


            [InverseProperty("Client")]
            public ICollection<ClientSupplier> ClientSuppliers { get; set; }
            [InverseProperty("MyClient")]
            public ICollection<Person> People { get; set; }
    }
}
