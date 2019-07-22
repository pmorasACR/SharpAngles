using Microsoft.EntityFrameworkCore;

namespace MyAPI.Models
{
    public class DeploymentGroupContext : DbContext
    {
        public DeploymentGroupContext(DbContextOptions<TodoContext> options) : base(options){}

        public DbSet<DeploymentGroup> groups {get;set;}
    }
}