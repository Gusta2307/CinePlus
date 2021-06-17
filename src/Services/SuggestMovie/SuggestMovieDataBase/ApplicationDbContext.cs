using Microsoft.EntityFrameworkCore;
using SuggestMovieDataBase.Configuration;
using SuggestMovieDomain;
using System;

namespace SuggestMovieDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<SuggestMovie> SuggestMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new SuggestMovieConfiguration(modelBuilder.Entity<SuggestMovie>());
        }
    }
}
