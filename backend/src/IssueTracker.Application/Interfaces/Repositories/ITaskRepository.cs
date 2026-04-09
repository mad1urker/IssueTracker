using IssueTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Interfaces.Repositories
{
    public interface ITaskRepository : IRepository<TaskItem>     
    {
        Task<IEnumerable<TaskItem>> GetByProjectIdAAsync(Guid projectId);
    }
}
