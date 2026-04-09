using IssueTracker.Application.Interfaces.Repositories;
using IssueTracker.Domain.Entities;
using IssueTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Infrastructure.Repositories
{
    public class TaskRepository : Repository<TaskItem>, ITaskRepository
    {
        public TaskRepository(AppDbContext context) : base(context) { }
        public async Task<IEnumerable<TaskItem>> GetByProjectIdAAsync(Guid projectId)
            => await _dbSet
                .Where(x => x.ProjectId == projectId)
                .ToListAsync();
    }
}
