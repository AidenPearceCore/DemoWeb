using System;
using System.Collections.Generic;

namespace DemoWeb.Models
{
    //Model
    #region
    public partial class House
    {
        public int Id { get; set; }
        public string? Estatename { get; set; }
        public string? City { get; set; }
        public string? Type { get; set; }
        public string? Floor { get; set; }
        public int? Numberofrooms { get; set; }
    }
    #endregion
}
