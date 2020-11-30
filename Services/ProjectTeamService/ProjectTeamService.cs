using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectTracker.Dtos.ProjectTeam;
using ProjectTracker.Models;
using ProjectTracket.Data;

namespace ProjectTracker.Services.ProjectTeamService
{
    public class ProjectTeamService : IProjectTeamService
    {
        private ProjectDBContext _context = null;
        private readonly IMapper _mapper;

        public ProjectTeamService(ProjectDBContext context,IMapper mapper){
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<GetProjectTeamDto>> AddProjectTeam(AddProjectTeamDto newProjectTeam)
        {
            ProjectTeam projectTeam = _mapper.Map<ProjectTeam>(newProjectTeam);
            // if(_context.Projects.FirstOrDefault(p => p.Id == 1)==null){
            //     project.Id = 1;
            // }else{
            // project.Id = _context.Projects.Max(p=> p.Id)+1;
            // }
            _context.ProjectTeams.Add(projectTeam);
            _context.SaveChanges();
            return _context.ProjectTeams.Select(p => _mapper.Map<GetProjectTeamDto>(p)).ToList();
        }

        public async Task<List<GetProjectTeamDto>> GetAllProjectTeams()
        {
            return _context.ProjectTeams.Select(p => _mapper.Map<GetProjectTeamDto>(p)).ToList();
        }

        public async Task<GetProjectTeamDto> GetProjectTeamByProjectId(int id)
        {
            return _mapper.Map<GetProjectTeamDto>(_context.ProjectTeams.FirstOrDefault(p => p.ProjectId == id));
        }

        public async Task<GetProjectTeamDto> UpdateProjectTeam(int id,UpdateProjectTeamDto updatedprojectteam)
        {
            GetProjectTeamDto projectteamdto = new GetProjectTeamDto();
            ProjectTeam projectTeam = _context.ProjectTeams.FirstOrDefault(p => p.ProjectTeamId == updatedprojectteam.ProjectTeamId);
            // project.Name = updatedproject.Name;
            // project.Description =updatedproject.Description;
            // project.Owner = updatedproject.Owner;
            // project.SME = updatedproject.SME;

            projectteamdto = _mapper.Map<GetProjectTeamDto>(projectTeam);
            _context.SaveChanges();
            return projectteamdto;

        }

    }
}