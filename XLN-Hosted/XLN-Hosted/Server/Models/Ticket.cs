using System;
using System.Collections.Generic;

namespace XLN_Hosted.Server.Models
{
    public partial class Ticket
    {
        public long TicketId { get; set; }
        public long UserId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long? Status { get; set; }
        public string? ImageUrl { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
