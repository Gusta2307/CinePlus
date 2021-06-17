using Microsoft.EntityFrameworkCore;
using ProgrammingDataBase.Configuration;
using ProgrammingDomain.Models;
using System;

namespace ProgrammingDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Programming> Programming { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ProgrammingConfiguration(modelBuilder.Entity<Programming>());
        }
    }
}
