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
        public async Task<bool> DeleteAsync(Guid id)
        {
            var task = await _taskRepository.GetByIdAsync(id);

            if (task is null)
                return false;

            await _taskRepository.DeleteAsync(id);
            await _taskRepository.SaveSaveChangesAsync();

            return true;
        }
        public async Task<IEnumerable<TaskItemDto>> GetAllAsync()
        {
            var tasks = await _taskRepository.GetAllAsync();
            return tasks.Select(x => x.Adapt<TaskItemDto>());
        }
        public async Task<TaskItemDto> GetByIdAsync(Guid id)
        {
            var task = await _taskRepository.GetByIdAsync(id);
            return task.Adapt<TaskItemDto>();
        }
        public async Task<TaskItemDto?> UpdateAsync(Guid id, UpdateTaskDto updateTaskDto)
        {
            var task = await _taskRepository.GetByIdAsync(id);

            if (task is null)
                return null;

            task.Title = updateTaskDto.Title;
            task.Description = updateTaskDto.Description;
            task.Status = updateTaskDto.Status;
            task.AssignedId = updateTaskDto.AssignedId;

            await _taskRepository.SaveSaveChangesAsync();

            return task.Adapt<TaskItemDto>();
        }
    }
}
