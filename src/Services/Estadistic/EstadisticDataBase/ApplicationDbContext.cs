using EstadisticDataBase.Configuration;
using EstadisticDomain;
using Microsoft.EntityFrameworkCore;
using System;

namespace EstadisticDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Estadistic> Estadistics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new EstadisticConfiguration(modelBuilder.Entity<Estadistic>());
        }
    }
}
