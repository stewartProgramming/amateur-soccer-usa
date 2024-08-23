using Microsoft.EntityFrameworkCore;

namespace Entities.Database
{
    public class RepositoryContext(DbContextOptions<RepositoryContext> options) : DbContext(options)
    {
        public DbSet<League> Leagues { get; set; }
    }
}
