using System;
using System.Collections.Generic;

namespace DemoWeb.Models
{
    public partial class Customer
    {
        public string Id { get; set; } = null!;
        public string? Gender { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Company { get; set; }

        public virtual Company IdNavigation { get; set; } = null!;
    }
}
