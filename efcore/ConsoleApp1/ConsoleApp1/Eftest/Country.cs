using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Eftest
{
[Table("Country")]
    public partial class Country
    {
        public Country()
        {
            Clients = new HashSet<Client>();
        }

        public int Id { get; set; }
        [StringLength(100)]
        public string CountryName { get; set; }


            [InverseProperty("Country")]
            public ICollection<Client> Clients { get; set; }
    }
}
