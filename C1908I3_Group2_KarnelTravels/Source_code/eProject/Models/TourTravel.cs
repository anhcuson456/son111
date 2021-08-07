using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class TourTravel
    {
        public int Id { get; set; }
        public string TourId { get; set; }
        public int? TravelId { get; set; }

        public virtual TouristSpot Tour { get; set; }
        public virtual Travel Travel { get; set; }
    }
}
