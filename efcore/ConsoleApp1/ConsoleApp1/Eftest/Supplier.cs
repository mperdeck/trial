using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Eftest
{
[Table("Supplier")]
    public partial class Supplier
    {
        public Supplier()
        {
            ClientSuppliers = new HashSet<ClientSupplier>();
        }

        public int Id { get; set; }
        [StringLength(100)]
        public string SupplierName { get; set; }


            [InverseProperty("Supplier")]
            public ICollection<ClientSupplier> ClientSuppliers { get; set; }
    }
}
