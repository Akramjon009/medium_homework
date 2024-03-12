using Medium.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Medium.Application.Absatractions
{
    public interface IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
