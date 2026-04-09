using IssueTracker.Application.DTOs.TaskItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Services.Interfaces
{
    public interface ITaskService
    {
        Task<TaskItemDto> GetByIdAsync(Guid id);
        Task<IEnumerable<TaskItemDto>> GetAllAsync();
        Task<TaskItemDto> CreateAsync(CreateTaskDto createTaskDto);
        Task<TaskItemDto> UpdateAsync(Guid id, CreateTaskDto updateTaskDto);
        Task DeleteAsync(Guid id);
    }
}
