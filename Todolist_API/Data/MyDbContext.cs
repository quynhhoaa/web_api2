using Microsoft.EntityFrameworkCore;

namespace Todolist_API.Data
{
    public class MyDbContext : DbContext
    {
       
        public MyDbContext(DbContextOptions options) : base( options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
