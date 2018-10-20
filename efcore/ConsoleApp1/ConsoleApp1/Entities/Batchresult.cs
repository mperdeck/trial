using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("batchresult")]
    public partial class Batchresult
    {
        [Key]
        [Column("batch_id")]
        public int BatchId { get; set; }
        [Column("upload_date", TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
        [Column("no_inserted")]
        public int? NoInserted { get; set; }
        [Column("no_updated")]
        public int? NoUpdated { get; set; }
        [Column("no_error")]
        public int? NoError { get; set; }
        [Column("no_set_inactive")]
        public int? NoSetInactive { get; set; }
    }
}
