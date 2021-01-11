using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTracker.Dtos.ProjectTeam;
using ProjectTracker.Services.ProjectTeamService;
using ProjectTracket.Data;

namespace ProjectTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTeamController : ControllerBase
    {
        private readonly IProjectTeamService _ProjectTeamService;

        public ProjectTeamController(IProjectTeamService projectTeamService){
            _ProjectTeamService = projectTeamService;

        }
        [HttpGet]
        public async Task<ActionResult> getAllProjectTeams(){
            return Ok(await _ProjectTeamService.GetAllProjectTeams());
        }
       
       [HttpGet("{id}")]
       public async Task<ActionResult> getProjectTeamByProjectId(int id){
            return Ok(await _ProjectTeamService.GetProjectTeamByProjectId(id));
        }

        [HttpPost]
        public async Task<ActionResult> addProjectTeam(AddProjectTeamDto newProjectTeam){
            return Ok(await _ProjectTeamService.AddProjectTeam(newProjectTeam));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> updateProjectTeam(int id,UpdateProjectTeamDto ProjectTeamdto){
            try
            {
                if(id!=ProjectTeamdto.ProjectTeamId){
                return BadRequest("Bad Request : Id not matching");
            }
            else{
            return Ok(await _ProjectTeamService.UpdateProjectTeam(id,ProjectTeamdto));
            }
            }
            catch (System.Exception)
            {
                
                return StatusCode(500, "Internal server error");
            }
            
        }
    }
}