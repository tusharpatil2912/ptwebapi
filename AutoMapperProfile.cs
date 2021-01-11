using AutoMapper;
using ProjectTracker.Dtos.Project;
using ProjectTracker.Dtos.ProjectTeam;
using ProjectTracker.Dtos.Issue;
using ProjectTracker.Dtos.Resource;
using ProjectTracker.Dtos.ProjectTask;
using ProjectTracker.Models;

namespace ProjectTracker
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Project, GetProjectDto>();
            CreateMap<AddProjectDto, Project>();
            CreateMap<UpdateProjectDto, Project>();

            CreateMap<ProjectTeam, GetProjectTeamDto>();
            CreateMap<AddProjectTeamDto, ProjectTeam>();
            CreateMap<UpdateProjectTeamDto, ProjectTeam>();

            CreateMap<Issue, GetIssueDto>();
            CreateMap<AddIssueDto, Issue>();
            CreateMap<UpdateIssueDto, Issue>();

            CreateMap<Resource, GetResourceDto>();
            CreateMap<AddResourceDto, Resource>();
            CreateMap<UpdateResourceDto, Resource>();

            CreateMap<ProjectTask, GetTaskDto>();
            CreateMap<AddTaskDto, ProjectTask>();
            CreateMap<UpdateTaskDto, ProjectTask>();
        }
    }
}