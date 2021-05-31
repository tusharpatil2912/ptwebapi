using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjectTracker.Dtos.ProjectTask;
using ProjectTracker.Models;
using ProjectTracket.Data;

namespace ProjectTracker.Services.TaskService
{
    public class TaskService : ITaskService
    {
        private ProjectDBContext _context = null;
        private readonly IMapper _mapper;

        public TaskService(ProjectDBContext context,IMapper mapper){
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<GetTaskDto>> AddTask(AddTaskDto newTask)
        {
            ProjectTask ProjectTask = _mapper.Map<ProjectTask>(newTask);
            // if(_context.Projects.FirstOrDefault(p => p.Id == 1)==null){
            //     project.Id = 1;
            // }else{
            // project.Id = _context.Projects.Max(p=> p.Id)+1;
            // }
            _context.ProjectTasks.Add(ProjectTask);
            _context.SaveChanges();
            return _context.ProjectTasks.Select(p => _mapper.Map<GetTaskDto>(p)).ToList();
        }

        public async Task<List<GetTaskDto>> GetAllTasks()
        {
            return _context.ProjectTasks.Select(p => _mapper.Map<GetTaskDto>(p)).ToList();
        }

        public async Task<List<GetTaskDto>> GetTaskByProjectId(int id)
        {
            return _context.ProjectTasks.Where(p => p.ProjectId ==id).Select(_mapper.Map<GetTaskDto>).ToList();
            //return _mapper.Map<GetTaskDto>(result);
            //return _context.ProjectTasks.Select(p => _mapper.Map<GetTaskDto>(p.ProjectId == id)).ToList();
            //return _mapper.Map<GetTaskDto>(_context.ProjectTasks.FirstOrDefault(p => p.ProjectId == id));
        }

        public async Task<GetTaskDto> GetTaskById(int id)
        {
            //return _context.ProjectTasks.Where(p => p.TaskId ==id).Select(_mapper.Map<GetTaskDto>).ToList();
            //return _mapper.Map<GetTaskDto>(result);
            //return _context.ProjectTasks.Select(p => _mapper.Map<GetTaskDto>(p.ProjectId == id)).ToList();
            return _mapper.Map<GetTaskDto>(_context.ProjectTasks.FirstOrDefault(p => p.TaskId == id));
        }

        public async Task<GetTaskDto> UpdateTask(int id,UpdateTaskDto updatedTask)
        {
            GetTaskDto Taskdto = new GetTaskDto();
            ProjectTask ProjectTask = _context.ProjectTasks.FirstOrDefault(p => p.TaskId == updatedTask.TaskId);
            // project.Name = updatedproject.Name;
            // project.Description =updatedproject.Description;
            // project.Owner = updatedproject.Owner;
            // project.SME = updatedproject.SME;

            Taskdto = _mapper.Map<GetTaskDto>(ProjectTask);
            _context.SaveChanges();
            return Taskdto;

        }

    }
}