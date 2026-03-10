using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Domain.Entities
{
    internal class ProjectMember
    {
        public int ProjectId { get; }
        public int UserId { get; }
    }
}
