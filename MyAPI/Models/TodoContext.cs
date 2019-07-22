using Microsoft.EntityFrameworkCore;

namespace MyAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options){}
        //contains 'database' items until an actual datbase is setup
        public DbSet<TodoItem> TodoItems {get;set;}
    }
}