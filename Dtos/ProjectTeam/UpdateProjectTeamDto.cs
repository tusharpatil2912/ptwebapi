using System;
namespace ProjectTracker.Dtos.ProjectTeam
{
    public class UpdateProjectTeamDto
    {
         public int ProjectTeamId { get; set; }
        public int ProjectId { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
    }
}