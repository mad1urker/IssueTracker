using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        ICollection<UserProject> UserProjects { get; set; } = new List<UserProject>() = [];  
        ICollection<TaskItem> TaskItems { get; set; } = new List<TaskItem>() = [];  
    }
}

