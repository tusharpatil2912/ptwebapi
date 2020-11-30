using System;
namespace ProjectTracker.Dtos.Issue
{
    public class AddIssueDto
    {
       //public int IssueId { get; set; }
        public int TaskId { get; set; }
        public int ProjectId { get; set; }
        public string IssueName { get; set; }
        public string IssueDesc { get; set; }
        public string IssueFacedBy { get; set; }
        public string IssueCreatedDate { get; set; }
    }
}