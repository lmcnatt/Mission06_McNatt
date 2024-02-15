using Microsoft.EntityFrameworkCore;

namespace Mission06_McNatt.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base(options) // Constructor
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}
