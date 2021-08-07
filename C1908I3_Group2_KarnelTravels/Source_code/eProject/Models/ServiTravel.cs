using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class ServiTravel
    {
        public int Id { get; set; }
        public string ServiId { get; set; }
        public int? TravelId { get; set; }

        public virtual Servi Servi { get; set; }
        public virtual Travel Travel { get; set; }
    }
}
