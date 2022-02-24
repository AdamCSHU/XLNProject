using System;
using System.Collections.Generic;

namespace XLN_Hosted.Server.Models
{
    public partial class User
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        public long UserId { get; set; }
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Username { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
