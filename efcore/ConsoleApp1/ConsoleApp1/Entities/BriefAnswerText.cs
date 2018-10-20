using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("BriefAnswerText")]
    public partial class BriefAnswerText
    {
        public int Id { get; set; }
        public int BriefId { get; set; }
        public int BriefTemplateQuestionId { get; set; }
        public string TextAnswer { get; set; }
    }
}
