using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectTracker.Dtos.Issue;
using ProjectTracker.Models;
using ProjectTracket.Data;

namespace ProjectTracker.Services.IssueService
{
    public class IssueService : IIssueService
    {
        private ProjectDBContext _context = null;
        private readonly IMapper _mapper;

        public IssueService(ProjectDBContext context,IMapper mapper){
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<GetIssueDto>> AddIssue(AddIssueDto newIssue)
        {
            Issue issue = _mapper.Map<Issue>(newIssue);
            // if(_context.Projects.FirstOrDefault(p => p.Id == 1)==null){
            //     project.Id = 1;
            // }else{
            // project.Id = _context.Projects.Max(p=> p.Id)+1;
            // }
            _context.Issues.Add(issue);
            _context.SaveChanges();
            return _context.Issues.Select(p => _mapper.Map<GetIssueDto>(p)).ToList();
        }

        public async Task<List<GetIssueDto>> GetAllIssues()
        {
            return _context.Issues.Select(p => _mapper.Map<GetIssueDto>(p)).ToList();
        }

        public async Task<List<GetIssueDto>> GetIssueByProjectId(int id)
        {
            return _context.Issues.Where(p => p.ProjectId ==id).Select(_mapper.Map<GetIssueDto>).ToList();
            //return _mapper.Map<GetIssueDto>(_context.Issues.FirstOrDefault(p => p.ProjectId == id));
        }

        public async Task<GetIssueDto> UpdateIssue(int id,UpdateIssueDto updatedIssue)
        {
            GetIssueDto Issuedto = new GetIssueDto();
            Issue issue = _context.Issues.FirstOrDefault(p => p.IssueId == updatedIssue.IssueId);
            // project.Name = updatedproject.Name;
            // project.Description =updatedproject.Description;
            // project.Owner = updatedproject.Owner;
            // project.SME = updatedproject.SME;

            Issuedto = _mapper.Map<GetIssueDto>(issue);
            _context.SaveChanges();
            return Issuedto;

        }

    }
}