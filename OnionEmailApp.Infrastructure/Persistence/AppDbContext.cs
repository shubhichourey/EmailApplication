using Microsoft.EntityFrameworkCore;
using OnionEmailApp.Domain.Entities;

namespace OnionEmailApp.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define DbSet for each entity
        public DbSet<Email> Emails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<Email>().HasData(
                new Email { Id = 1, EmailAddress = "user1@example.com" },
                new Email { Id = 2, EmailAddress = "user2@example.com" }
            );
        }
    }
}
