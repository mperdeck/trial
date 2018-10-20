using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("ImportSheet")]
    public partial class ImportSheet
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int ImportId { get; set; }
        public int ImportTypeSheetId { get; set; }
        public int? NumberOfInserts { get; set; }
        public int? NumberOfUpdates { get; set; }
        public int? NumberOfDeletes { get; set; }
        public string Xml { get; set; }
    }
}
