using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    internal class Project
    {
        public int Id { get; }
        public string? Name { get; }
        public string? Description { get; }
        public DateTime CreatedAtUtc { get; }
        public DateTime UpdatedAtUtc { get; }
    }
}

