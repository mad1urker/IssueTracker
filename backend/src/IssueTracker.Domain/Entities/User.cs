using IssueTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class User
    {
        public required int Id { get;set; }
        public required string? Name { get; set; }
        public required int? Age { get; set; }
        public required string? Email { get; set; }
        public required string? PasswordHash { get; set; }
        public required UserRole Role { get; set;}
        public required DateTime CreatedAtUtc { get; set; }
    }
}
