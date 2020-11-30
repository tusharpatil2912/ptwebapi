using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.Models
{

    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int NoOfProjects { get; set; }
        public string TasksAssigned { get; set; }
        public Resource(){}

    }


}