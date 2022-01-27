using Microsoft.EntityFrameworkCore;
using BuildManager.Models;

namespace BuildManager.Data
{
    class ApplicationContext : DbContext
    {
        public DbSet<BuildManagerModel> Works { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BuildManagerDB;Trusted_Connection=True;");
        }
    }
}
