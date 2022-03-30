using System;
using System.Collections.Generic;

namespace DemoWeb.Models
{
    public partial class Company
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? Tel { get; set; }
        public string? Address { get; set; }
        public string? Contect { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
