using System.Dynamic;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DataCarEF2
{
    public class DataCarEF : DbContext
    {
        public DbSet<Car> Car { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=Mohammed;TrustServerCertificate=true;Trusted_Connection=true",
                optionsBuilder => optionsBuilder.EnableRetryOnFailure());
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorialAppSchemaMohammd");
            modelBuilder.Entity<Car>().HasKey(p=>p.CarId);
        }
    }
}