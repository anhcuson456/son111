using System;
using System.Collections.Generic;

#nullable disable

namespace eProject.Models
{
    public partial class Account
    {
        public Account()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Addr { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public bool? Stt { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
