using BookingDataBase.Configuration;
using BookingDomain;
using Microsoft.EntityFrameworkCore;

namespace BookingDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new BookingConfiguration(modelBuilder.Entity<Booking>());
        }
    }
}
