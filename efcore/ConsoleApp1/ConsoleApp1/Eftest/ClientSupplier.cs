using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Eftest
{
[Table("ClientSupplier")]
    public partial class ClientSupplier
    {
        public int ClientId { get; set; }
        public int SupplierId { get; set; }
        [StringLength(100)]
        public string RelationshipName { get; set; }
        public int Id { get; set; }


            [ForeignKey("ClientId")]
            [InverseProperty("ClientSuppliers")]
                public Client Client { get; set; }
            [ForeignKey("SupplierId")]
            [InverseProperty("ClientSuppliers")]
                public Supplier Supplier { get; set; }
    }
}
