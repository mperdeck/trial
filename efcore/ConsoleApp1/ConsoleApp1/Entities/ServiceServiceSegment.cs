using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("Service_ServiceSegment")]
    public partial class ServiceServiceSegment
    {
        public int ServiceId { get; set; }
        public int ServiceSegmentId { get; set; }
    }
}
