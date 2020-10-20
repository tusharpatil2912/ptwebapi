using AutoMapper;
using ProjectTracker.Dtos.Project;
using ProjectTracker.Models;

namespace ProjectTracker
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Project, GetProjectDto>();
            CreateMap<AddProjectDto, Project>();
        }
    }
}