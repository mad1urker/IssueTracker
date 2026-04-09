using IssueTracker.Application.DTOs.TaskItem;
using IssueTracker.Application.Interfaces.Repositories;
using IssueTracker.Application.Services.Interfaces;
using IssueTracker.Domain.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<TaskItemDto> CreateAsync(CreateTaskDto createTaskDto)
        {
            TaskItem taskItem = createTaskDto.Adapt<TaskItem>();

            await _taskRepository.AddAsync(taskItem);
            await _taskRepository.SaveSaveChangesAsync();

            await _taskRepository.SaveSaveChangesAsync();

            return taskItem.Adapt<TaskItemDto>();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItemDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TaskItemDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItemDto> UpdateAsync(Guid id, CreateTaskDto updateTaskDto)
        {
            throw new NotImplementedException();
        }
    }
}
