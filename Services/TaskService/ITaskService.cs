using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectTracker.Dtos.ProjectTask;
using ProjectTracker.Models;

namespace ProjectTracker.Services.TaskService
{
    public interface ITaskService
    {
        Task<List<GetTaskDto>> GetAllTasks();
        Task<List<GetTaskDto>> GetTaskByProjectId(int id);
        Task<GetTaskDto> GetTaskById(int id);
        Task<List<GetTaskDto>> AddTask(AddTaskDto newTask);
        Task<GetTaskDto> UpdateTask(int id,UpdateTaskDto Taskdto);
    }
}