using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class TouristSpot
    {
        public TouristSpot()
        {
            Comments = new HashSet<Comment>();
            Imgs = new List<Img>();
            Servis = new HashSet<Servi>();
            TourTravels = new HashSet<TourTravel>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Addr { get; set; }
        public string Descrip { get; set; }
        public string Active { get; set; }
        public int CategoryId { get; set; }
        public bool Stt { get; set; }

        public virtual CategoryTour Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual IList<Img> Imgs { get; set; }
        public virtual ICollection<Servi> Servis { get; set; }
        public virtual ICollection<TourTravel> TourTravels { get; set; }
    }
}
