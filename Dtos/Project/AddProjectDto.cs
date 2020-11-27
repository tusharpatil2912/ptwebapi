using System;
namespace ProjectTracker.Dtos.Project
{
    public class AddProjectDto
    {
        //public int Id{get;set;}
        public string Name{get;set;}
        public string Description{get;set;}
        public string Owner{get;set;}
        public string SME{get;set;}
        public string Phase{get;set;}
        public string CodeDropDate{get;set;}
        public string CodeFreezeDate{get;set;}
        public string ReleaseDate{get;set;}
        public string CreatedDate{get;set;}
    }
}