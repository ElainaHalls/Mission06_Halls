using Microsoft.EntityFrameworkCore;

namespace Mission06_Halls.Models
{
    public class MoviesApplicationContext : DbContext
    {
        public MoviesApplicationContext(DbContextOptions<MoviesApplicationContext> options) : base (options) 
        {
        }

        public DbSet<Application> Applications { get; set; }
    }
}
