using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class Travel
    {
        public Travel()
        {
            ServiTravels = new HashSet<ServiTravel>();
            TourTravels = new HashSet<TourTravel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }

        public virtual ICollection<ServiTravel> ServiTravels { get; set; }
        public virtual ICollection<TourTravel> TourTravels { get; set; }
    }
}
