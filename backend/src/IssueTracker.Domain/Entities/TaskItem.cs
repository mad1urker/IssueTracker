using System;

namespace IssueTracker.Domain.Entities
{

    public enum TaskItemStatus
    {
        ToDo,
        InProgress,
        Done
    }
    
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskItemStatus Status { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public Guid? AssignedId { get; set; }
        public User Assigned { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = [];
    }
}