using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectTracker.Dtos.Project;
using ProjectTracker.Models;

namespace ProjectTracker.Services.ProjectService
{
    public interface IProjectService
    {
        Task<List<GetProjectDto>> GetAllProjects();
        Task<GetProjectDto> GetProjectById(int id);
        Task<List<GetProjectDto>> AddProject(AddProjectDto newProject);
    }
}