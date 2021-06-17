using ArmchairDataBase.Configuration;
using ArmchairDomain;
using Microsoft.EntityFrameworkCore;
using System;

namespace ArmchairDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Armchair> Armchairs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new ArmchairConfiguration(modelBuilder.Entity<Armchair>());
        }
    }
}
