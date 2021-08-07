using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class Img
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ServiId { get; set; }
        public string TourId { get; set; }

        public virtual Servi Servi { get; set; }
        public virtual TouristSpot Tour { get; set; }
    }
}
