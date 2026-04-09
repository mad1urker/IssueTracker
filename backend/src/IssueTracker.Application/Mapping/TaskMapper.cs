using IssueTracker.Application.DTOs.TaskItem;
using IssueTracker.Domain.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTracker.Application.Mapping
{
    public class TaskMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateTaskDto, TaskItem>()
                .Map(dest => dest.Status, src => TaskItemStatus.ToDo)
                .Map(dest => dest.Id, src => Guid.NewGuid());
        }
    }
}
