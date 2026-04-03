using IssueTracker.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public ICollection<TaskItem> TaskItems { get; set; } = [];
        public ICollection<UserProject> UserProjects { get; set; } = [];  
    }
}
