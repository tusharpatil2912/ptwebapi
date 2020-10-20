using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTracker.Dtos.Project;
using ProjectTracker.Services.ProjectService;
using ProjectTracket.Data;

namespace ProjectTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService){
            _projectService = projectService;

        }
        [HttpGet]
        public async Task<ActionResult> getAllProjects(){
            return Ok(await _projectService.GetAllProjects());
        }
       
       [HttpGet("{id}")]
       public async Task<ActionResult> getProjectById(int id){
            return Ok(await _projectService.GetProjectById(id));
        }

        [HttpPost]
        public async Task<ActionResult> addProject(AddProjectDto newProject){
            return Ok(await _projectService.AddProject(newProject));
        }
    }
}