using Microsoft.EntityFrameworkCore;
using ODataSample.DAL.Configurations;
using ODataSample.Models;
using ODataSample.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataSample.DAL.DbContexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            UpdateEntitiesInfo();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            UpdateEntitiesInfo();
            return await base.SaveChangesAsync();
        }
        private void UpdateEntitiesInfo()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((BaseEntity)entry.Entity).Created = DateTime.UtcNow;
                }
                ((BaseEntity)entry.Entity).Modified = DateTime.UtcNow;
            }
        }
    }
}
