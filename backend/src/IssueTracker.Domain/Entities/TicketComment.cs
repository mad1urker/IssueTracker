using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    internal class TicketComment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int AuthorUserId { get; set; }
        public string? Text { get; set; }
        public DateTime CreatedAtUtc { get; set; }

    }
}
