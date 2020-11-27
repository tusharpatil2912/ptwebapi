using Microsoft.EntityFrameworkCore;
using ProjectTracker.Models;

namespace ProjectTracket.Data
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base (options)
        {}
        public DbSet<Project> Projects{get;set;}
        public DbSet<ProjectTask> ProjectTasks{get;set;}
        public DbSet<Resource> Resources{get;set;}
        public DbSet<Issue> Issues{get;set;}
        public DbSet<ProjectTeam> ProjectTeams{get;set;}
    }
}