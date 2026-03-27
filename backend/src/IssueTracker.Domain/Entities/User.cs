using IssueTracker.Domain.Enums;
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

        ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>() = [];
        ICollection<UserProject> UserProjects { get; set; } = new List<UserProject>() = [];  
    }
}
