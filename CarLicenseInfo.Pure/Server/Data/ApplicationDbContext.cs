using Microsoft.EntityFrameworkCore;

namespace CarLicenseInfo.Pure.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarLicenseInfo>()
                .HasKey(x => x.Id);
        }

        public DbSet<CarLicenseInfo> CarLicenseInfo { get; set; }
    }   
}