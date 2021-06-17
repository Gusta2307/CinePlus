using Microsoft.EntityFrameworkCore;
using PunctuationDataBase.Configuration;
using PunctuationDomain;
using System;

namespace PunctuationDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Punctuation> PunctuationsMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new PunctuationMovieConfiguration(modelBuilder.Entity<Punctuation>());
        }
    }

}
