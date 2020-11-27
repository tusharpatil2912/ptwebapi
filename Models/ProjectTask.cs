using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.Models
{

    public class ProjectTask
    {
        [Key]
        public int TaskId { get; set; }
        public int ProjectId { get; set; }
        public string TaskName { get; set; }
        public string TaskStatus { get; set; }
        public string TaskDetails { get; set; }
        public string EmpId { get; set; }

    }


}