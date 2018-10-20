using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("BriefAnswerOption")]
    public partial class BriefAnswerOption
    {
        public int Id { get; set; }
        public int BriefId { get; set; }
        public int BriefTemplateQuestionId { get; set; }
        public int BriefTemplateQuestionOptionId { get; set; }
    }
}
