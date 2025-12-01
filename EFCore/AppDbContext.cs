using EFCore.Configurations;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
namespace EFCore
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server = MUHAMMAD\SQLEXPRESS;Database=EFCore;Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --AnOther Way to Apply Configuration One by One [ Not Recommended ]
            // new BlogConfiguration().Configure(modelBuilder.Entity<Blog>()); 
           
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Blog> Blogs { get; set; }

    }
}
