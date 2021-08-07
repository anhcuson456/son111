using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class CategoryTour
    {
        public CategoryTour()
        {
            TouristSpots = new HashSet<TouristSpot>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TouristSpot> TouristSpots { get; set; }
    }
}
