using Medium.Application.Absatractions;
using Medium.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Medium.Infractructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.Migrate();

        }
        public DbSet<User> Users { get; set; }

    }
}
