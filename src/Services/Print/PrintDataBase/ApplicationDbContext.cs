using Microsoft.EntityFrameworkCore;
using PrintDataBase.Configuration;
using PrintDomain;
using System;

namespace PrintDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Printer> Printers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new PrinterConfiguration(modelBuilder.Entity<Printer>());
        }
    }
}
