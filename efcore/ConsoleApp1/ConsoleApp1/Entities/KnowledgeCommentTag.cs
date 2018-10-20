using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("KnowledgeCommentTag")]
    public partial class KnowledgeCommentTag
    {
        public int KnowledgeCommentId { get; set; }
        public int KnowledgeTagId { get; set; }
    }
}
