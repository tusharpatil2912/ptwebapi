using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace ProjectTracker.Models
{

    public class Issue
    {
        [Key]
        public int IssueId { get; set; }
        public int TaskId { get; set; }
        public int ProjectId { get; set; }
        public string IssueName { get; set; }
        public string IssueDesc { get; set; }
        public string IssueFacedBy { get; set; }
        
        public Issue(){}

    }


}