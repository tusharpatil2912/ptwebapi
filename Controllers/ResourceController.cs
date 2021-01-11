using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTracker.Dtos.Resource;
using ProjectTracker.Services.ResourceService;
using ProjectTracket.Data;

namespace ProjectTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly IResourceService _ResourceService;

        public ResourceController(IResourceService resourceService){
            _ResourceService = resourceService;

        }
        [HttpGet]
        public async Task<ActionResult> getAllResources(){
            return Ok(await _ResourceService.GetAllResources());
        }
       
       [HttpGet("{id}")]
       public async Task<ActionResult> getResourceById(int id){
            return Ok(await _ResourceService.GetResourceById(id));
        }

        [HttpPost]
        public async Task<ActionResult> addResource(AddResourceDto newResource){
            return Ok(await _ResourceService.AddResource(newResource));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> updateResource(int id,UpdateResourceDto Resourcedto){
            try
            {
                if(id!=Resourcedto.ResourceId){
                return BadRequest("Bad Request : Id not matching");
            }
            else{
            return Ok(await _ResourceService.UpdateResource(id,Resourcedto));
            }
            }
            catch (System.Exception)
            {
                
                return StatusCode(500, "Internal server error");
            }
            
        }
    }
}