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
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public int? Age { get; private set; }
        public string? Email { get; private set; }
        public string? PasswordHash { get; private set; }
        public UserRole Role { get; private set;}
        public DateTime CreatedAtUtc { get; private set; }
    }
}
