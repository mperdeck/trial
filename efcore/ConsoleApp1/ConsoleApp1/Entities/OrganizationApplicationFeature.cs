using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{
[Table("OrganizationApplicationFeature")]
    public partial class OrganizationApplicationFeature
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public int ClientId { get; set; }
        public int ApplicationFeatureId { get; set; }
        public bool IsEnabled { get; set; }
        public string Conditions { get; set; }
    }
}
