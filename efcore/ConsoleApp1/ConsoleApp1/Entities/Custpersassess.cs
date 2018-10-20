using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("custpersassess")]
    public partial class Custpersassess
    {
        [Column("custpers_id")]
        public int CustpersId { get; set; }
        [Column("assesstype_id")]
        public int AssesstypeId { get; set; }
        [Column("person_id")]
        public int? PersonId { get; set; }
        [Column("modified_date", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}
