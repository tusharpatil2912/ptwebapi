using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectTracker.Dtos.ProjectTeam;
using ProjectTracker.Models;

namespace ProjectTracker.Services.ProjectTeamService
{
    public interface IProjectTeamService
    {
        Task<List<GetProjectTeamDto>> GetAllProjectTeams();
        Task<GetProjectTeamDto> GetProjectTeamByProjectId(int id);
        Task<List<GetProjectTeamDto>> AddProjectTeam(AddProjectTeamDto newProjectTeam);
        Task<GetProjectTeamDto> UpdateProjectTeam(int id,UpdateProjectTeamDto projectteamdto);
    }
}