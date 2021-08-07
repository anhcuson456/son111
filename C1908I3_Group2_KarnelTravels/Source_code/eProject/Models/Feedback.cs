using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Addr { get; set; }
        public string Content { get; set; }
    }
}
