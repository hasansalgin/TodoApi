using Microsoft.EntityFrameworkCore;

namespace TodoApi.Data
{
    public class TodoContext:DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {
            
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem() { Id = 1, Title = "Prepare Shopping List", Done = false },
                new TodoItem() { Id = 2, Title = "Complete Weekly Report", Done = false },
                new TodoItem() { Id = 3, Title = "Read a Book", Done = true },
                new TodoItem() { Id = 4, Title = "Go to the Gym", Done = true }
            );
        }
    }
}
