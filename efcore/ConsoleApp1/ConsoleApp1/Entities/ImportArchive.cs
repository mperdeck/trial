using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ImportArchive")]
    public partial class ImportArchive
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int ImportSheetId { get; set; }
        public string Content { get; set; }
    }
}
