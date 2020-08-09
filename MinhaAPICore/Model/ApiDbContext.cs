using Microsoft.EntityFrameworkCore;

namespace MinhaAPICore.Model
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
