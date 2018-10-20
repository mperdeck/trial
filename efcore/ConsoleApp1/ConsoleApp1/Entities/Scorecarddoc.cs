using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("scorecarddoc")]
    public partial class Scorecarddoc
    {
        [Column("scorecarddoc_id")]
        public int ScorecarddocId { get; set; }
        [Column("decision_id")]
        public int DecisionId { get; set; }
        [Column("supplier_doc_name")]
        [StringLength(100)]
        public string SupplierDocName { get; set; }
        [Column("supplier_doc_type")]
        [StringLength(100)]
        public string SupplierDocType { get; set; }
        [Column("supplier_doc_size")]
        [StringLength(100)]
        public string SupplierDocSize { get; set; }
        [Column("client_doc_name")]
        [StringLength(100)]
        public string ClientDocName { get; set; }
        [Column("client_doc_type")]
        [StringLength(100)]
        public string ClientDocType { get; set; }
        [Column("client_doc_size")]
        [StringLength(100)]
        public string ClientDocSize { get; set; }
        [Column("supplier_declined")]
        [StringLength(1)]
        public string SupplierDeclined { get; set; }
        [Column("supplier_comment")]
        [StringLength(1000)]
        public string SupplierComment { get; set; }
        [Column("client_declined")]
        [StringLength(1)]
        public string ClientDeclined { get; set; }
        [Column("client_comment")]
        [StringLength(1000)]
        public string ClientComment { get; set; }
    }
}
