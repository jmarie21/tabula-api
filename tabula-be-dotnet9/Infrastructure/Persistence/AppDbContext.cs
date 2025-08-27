using Microsoft.EntityFrameworkCore;
using tabula_be_dotnet9.Domain.Entities;

namespace tabula_be_dotnet9.Infrastructure.Persistence
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public virtual DbSet<User> Users { get; set; }
    }
}
