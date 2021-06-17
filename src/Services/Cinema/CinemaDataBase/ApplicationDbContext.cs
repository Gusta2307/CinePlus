using CinemaDataBase.Configuration;
using CinemaDomain;
using Microsoft.EntityFrameworkCore;

namespace CinemaDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Cinema> Cinemas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new CinemaConfiguration(modelBuilder.Entity<Cinema>());
        }
    }
}
