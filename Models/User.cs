using System;
using System.Collections.Generic;

namespace DemoWeb.Models
{
    public partial class User
    {
        public string Id { get; set; } = null!;
        public string? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Mobile { get; set; }
        public string? Password { get; set; }
        public string? HashSaltedPwd { get; set; }
        public string? Admin { get; set; }
        public string? Vender { get; set; }
        public string? Role { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public string? Intro { get; set; }
        public string? Profile { get; set; }
    }
}
