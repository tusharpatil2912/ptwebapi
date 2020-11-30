using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectTracker.Dtos.Resource;
using ProjectTracker.Models;
using ProjectTracket.Data;

namespace ProjectTracker.Services.ResourceService
{
    public class ResourceService : IResourceService
    {
        private ProjectDBContext _context = null;
        private readonly IMapper _mapper;

        public ResourceService(ProjectDBContext context,IMapper mapper){
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<GetResourceDto>> AddResource(AddResourceDto newResource)
        {
            Resource resource = _mapper.Map<Resource>(newResource);
            // if(_context.Projects.FirstOrDefault(p => p.Id == 1)==null){
            //     project.Id = 1;
            // }else{
            // project.Id = _context.Projects.Max(p=> p.Id)+1;
            // }
            _context.Resources.Add(resource);
            _context.SaveChanges();
            return _context.Resources.Select(p => _mapper.Map<GetResourceDto>(p)).ToList();
        }

        public async Task<List<GetResourceDto>> GetAllResources()
        {
            return _context.Resources.Select(p => _mapper.Map<GetResourceDto>(p)).ToList();
        }

        public async Task<GetResourceDto> GetResourceById(int id)
        {
            return _mapper.Map<GetResourceDto>(_context.Resources.FirstOrDefault(p => p.ResourceId == id));
        }

        public async Task<GetResourceDto> UpdateResource(int id,UpdateResourceDto updatedResource)
        {
            GetResourceDto Resourcedto = new GetResourceDto();
            Resource resource = _context.Resources.FirstOrDefault(p => p.ResourceId == updatedResource.ResourceId);
            // project.Name = updatedproject.Name;
            // project.Description =updatedproject.Description;
            // project.Owner = updatedproject.Owner;
            // project.SME = updatedproject.SME;

            Resourcedto = _mapper.Map<GetResourceDto>(resource);
            _context.SaveChanges();
            return Resourcedto;

        }

    }
}