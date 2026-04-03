using System;

namespace IssueTracker.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; } = string.Empty;

        //Foreign Keys
        public Guid AuthorId { get; set; }
        public User Author { get; set; } = null!;

        //Navigation Properties
        public Guid TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; } = null!;
    }
}