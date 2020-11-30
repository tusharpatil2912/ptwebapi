using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectTracker.Dtos.Resource;
using ProjectTracker.Models;

namespace ProjectTracker.Services.ResourceService
{
    public interface IResourceService
    {
        Task<List<GetResourceDto>> GetAllResources();
        Task<GetResourceDto> GetResourceById(int id);
        Task<List<GetResourceDto>> AddResource(AddResourceDto newResource);
        Task<GetResourceDto> UpdateResource(int id,UpdateResourceDto resourcedto);
    }
}