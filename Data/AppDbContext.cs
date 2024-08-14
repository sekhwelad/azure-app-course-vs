using Microsoft.EntityFrameworkCore;

namespace azure_app_course_vs.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) 
        {
            
        }

        public DbSet<Person> Person { get; set; }
    }
}
