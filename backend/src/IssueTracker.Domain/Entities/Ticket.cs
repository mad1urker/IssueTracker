using IssueTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    internal class Ticket
    {
        public int Id { get; }
        public string? Title { get; }
        public string? Description { get; }
        public TicketStatus Status { get; set; }
        public TicketPiority Piority { get; set; }
        public int? ProjectId { get; set; }
        public DateTime CreatedByUserId { get; set; }
        public int? AssigneeUserId { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime UpdatedByUserId { get; set; }
    }
}

