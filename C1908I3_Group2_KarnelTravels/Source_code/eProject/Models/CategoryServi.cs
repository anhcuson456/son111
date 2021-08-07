using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class CategoryServi
    {
        public CategoryServi()
        {
            Servis = new HashSet<Servi>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Servi> Servis { get; set; }
    }
}
