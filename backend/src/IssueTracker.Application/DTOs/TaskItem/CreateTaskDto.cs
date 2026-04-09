using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.DTOs.TaskItem
{
    public class CreateTaskDto
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; } 
        public Guid ProjectId { get; set; }
        public Guid? AssignedId { get; set; }
    }
}
