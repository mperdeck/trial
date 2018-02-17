using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core1.Models
{
    public class ViewModel
    {
        public int Int1 { get; set; }
        public string String1 { get; set; }
        public bool Bool1 { get; set; }

        [Required]
        public string String2 { get; set; }
    }
}
