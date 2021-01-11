using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectTracker.Dtos.Issue;
using ProjectTracker.Models;

namespace ProjectTracker.Services.IssueService
{
    public interface IIssueService
    {
        Task<List<GetIssueDto>> GetAllIssues();
        Task<List<GetIssueDto>> GetIssueByProjectId(int id);
        Task<List<GetIssueDto>> AddIssue(AddIssueDto newIssue);
        Task<GetIssueDto> UpdateIssue(int id,UpdateIssueDto issuedto);
    }
}