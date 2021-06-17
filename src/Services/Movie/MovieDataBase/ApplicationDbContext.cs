using Microsoft.EntityFrameworkCore;
using MovieDataBase.Configuration;
using MovieDomain;
using System;

namespace MovieDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new MovieConfiguration(modelBuilder.Entity<Movie>());
        }
    }
}
