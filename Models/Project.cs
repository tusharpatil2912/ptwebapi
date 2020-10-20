using System;
namespace ProjectTracker.Models
{
    public class Project
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Description{get;set;}
        public string Owner{get;set;}
        public string SME{get;set;}
    }
}