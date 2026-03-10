using IssueTracker.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    internal class User
    {
        public int Id { get; }
        public string? Name { get; }
        public string? Email { get; }
        public string? PasswordHash { get; }
        public UserRole Role { get; }
        public DateTime CreatedAtUtc { get; }
    }
}
