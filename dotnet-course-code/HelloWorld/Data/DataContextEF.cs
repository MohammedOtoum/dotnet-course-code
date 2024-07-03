using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;

namespace HelloWorld.Database
{
    public class dataContextEF : DbContext
    {
        private string? _connectionString;
        public dataContextEF(IConfiguration configration)
        {
            //_config=configration;
            _connectionString = configration.GetConnectionString("DefaultConnection");

        }
        public DbSet<Computer>? Computer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString,
                optionsBuilder => optionsBuilder.EnableRetryOnFailure());
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorialAppSchemaMohammd");
            modelBuilder.Entity<Computer>()
            // .HasNoKey()
            .HasKey(C => C.ComputerId);
            // .ToTable("Computer", "TutorialAppSchemaMohammd");


        }
    }

}
