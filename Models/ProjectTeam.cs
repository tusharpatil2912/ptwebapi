using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.Models
{

    public class ProjectTeam
    {
        [Key]
        public int ProjectTeamId { get; set; }
        public int ProjectId { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        
    }


}