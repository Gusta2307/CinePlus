using GangawayDataBase.Configuration;
using GangwayDomain;
using Microsoft.EntityFrameworkCore;
using System;

namespace GangawayDataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UserPay> Pays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ModelConfig(modelBuilder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new UserPayConfiguration(modelBuilder.Entity<UserPay>());
        }
    }
}
