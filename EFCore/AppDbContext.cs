using Microsoft.EntityFrameworkCore;
namespace EFCore
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server = MUHAMMAD\SQLEXPRESS;Database=EFCore;Trusted_Connection=True;TrustServerCertificate=True;");

        public DbSet<Employee> Employees { get; set; }

    }
}
