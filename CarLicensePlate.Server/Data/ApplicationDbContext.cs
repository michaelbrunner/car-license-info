using Microsoft.EntityFrameworkCore;

namespace CarLicensePlate.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarLicensePlate>()
                .HasKey(x => x.Id);
        }

        public DbSet<CarLicensePlate> CarLicensePlate { get; set; }
    }   
}