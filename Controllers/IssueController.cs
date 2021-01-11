using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTracker.Dtos.Issue;
using ProjectTracker.Services.IssueService;
using ProjectTracket.Data;

namespace ProjectTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        private readonly IIssueService _IssueService;

        public IssueController(IIssueService issueService){
            _IssueService = issueService;

        }
        [HttpGet]
        public async Task<ActionResult> getAllIssues(){
            return Ok(await _IssueService.GetAllIssues());
        }
       
       [HttpGet("{id}")]
       public async Task<ActionResult> getIssueByProjectId(int id){
            return Ok(await _IssueService.GetIssueByProjectId(id));
        }

        [HttpPost]
        public async Task<ActionResult> addIssue(AddIssueDto newIssue){
            return Ok(await _IssueService.AddIssue(newIssue));
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> updateIssue(int id,UpdateIssueDto Issuedto){
            try
            {
                if(id!=Issuedto.IssueId){
                return BadRequest("Bad Request : Id not matching");
            }
            else{
            return Ok(await _IssueService.UpdateIssue(id,Issuedto));
            }
            }
            catch (System.Exception)
            {
                
                return StatusCode(500, "Internal server error");
            }
            
        }
    }
}