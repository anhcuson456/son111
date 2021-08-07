using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class Servi
    {
        public Servi()
        {
            Comments = new HashSet<Comment>();
            Imgs = new List<Img>();
            ServiTravels = new HashSet<ServiTravel>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Addr { get; set; }
        public string Descrip { get; set; }
        public decimal? Price { get; set; }
        public string TourId { get; set; }
        public int CategoryId { get; set; }
        public bool Stt { get; set; }

        public virtual CategoryServi Category { get; set; }
        public virtual TouristSpot Tour { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual IList<Img> Imgs { get; set; }
        public virtual ICollection<ServiTravel> ServiTravels { get; set; }
    }
}
