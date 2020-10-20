using Microsoft.EntityFrameworkCore;
using ProjectTracker.Models;

namespace ProjectTracket.Data
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base (options)
        {}
        public DbSet<Project> Projects{get;set;}
    }
}