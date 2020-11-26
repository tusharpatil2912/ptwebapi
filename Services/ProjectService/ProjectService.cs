using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectTracker.Dtos.Project;
using ProjectTracker.Models;
using ProjectTracket.Data;

namespace ProjectTracker.Services.ProjectService
{
    public class ProjectService : IProjectService
    {
        private ProjectDBContext _context = null;
        private readonly IMapper _mapper;

        public ProjectService(ProjectDBContext context,IMapper mapper){
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<GetProjectDto>> AddProject(AddProjectDto newProject)
        {
            Project project = _mapper.Map<Project>(newProject);
            project.Id = _context.Projects.Max(p=> p.Id)+1;
            _context.Projects.Add(project);
            _context.SaveChanges();
            return _context.Projects.Select(p => _mapper.Map<GetProjectDto>(p)).ToList();
        }

        public async Task<List<GetProjectDto>> GetAllProjects()
        {
            return _context.Projects.Select(p => _mapper.Map<GetProjectDto>(p)).ToList();
        }

        public async Task<GetProjectDto> GetProjectById(int id)
        {
            return _mapper.Map<GetProjectDto>(_context.Projects.FirstOrDefault(p => p.Id == id));
        }

        public async Task<GetProjectDto> UpdateProject(int id,UpdateProjectDto updatedproject)
        {
            GetProjectDto projectdto = new GetProjectDto();
            Project project = _context.Projects.FirstOrDefault(p => p.Id == updatedproject.Id);
            project.Name = updatedproject.Name;
            project.Description =updatedproject.Description;
            project.Owner = updatedproject.Owner;
            project.SME = updatedproject.SME;

            projectdto = _mapper.Map<GetProjectDto>(project);
            _context.SaveChanges();
            return projectdto;

        }

    }
}