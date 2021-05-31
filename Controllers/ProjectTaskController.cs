using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTracker.Dtos.ProjectTask;
using ProjectTracker.Services.TaskService;
using ProjectTracket.Data;

namespace ProjectTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTaskController : ControllerBase
    {
        private readonly ITaskService _projectTaskService;

        public ProjectTaskController(ITaskService projectTaskService){
            _projectTaskService = projectTaskService;

        }
        [HttpGet]
        public async Task<ActionResult> getAllTasks(){
            return Ok(await _projectTaskService.GetAllTasks());
        }
       
       [HttpGet("{id}")]
       public async Task<ActionResult> getTaskByProjectId(int id){
            return Ok(await _projectTaskService.GetTaskByProjectId(id));
        }

        [HttpGet("taskid/{taskId}")]
       public async Task<ActionResult> getTaskById(int taskId){
            return Ok(await _projectTaskService.GetTaskById(taskId));
        }

        [HttpPost]
        public async Task<ActionResult> addTask(AddTaskDto newTask){
            return Ok(await _projectTaskService.AddTask(newTask));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> updateTask(int id,UpdateTaskDto Taskdto){
            try
            {
                if(id!=Taskdto.TaskId){
                return BadRequest("Bad Request : Id not matching");
            }
            else{
            return Ok(await _projectTaskService.UpdateTask(id,Taskdto));
            }
            }
            catch (System.Exception)
            {
                
                return StatusCode(500, "Internal server error");
            }
            
        }
    }
}