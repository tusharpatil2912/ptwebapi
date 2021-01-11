using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTracker.Dtos.Resource
{

    public class GetResourceDto
    {
        
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int NoOfProjects { get; set; }
        public string TasksAssigned { get; set; }

    }


}