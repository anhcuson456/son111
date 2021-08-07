using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int? AccId { get; set; }
        public string TourId { get; set; }
        public string ServiId { get; set; }
        public string Content { get; set; }

        public virtual Account Acc { get; set; }
        public virtual Servi Servi { get; set; }
        public virtual TouristSpot Tour { get; set; }
    }
}
