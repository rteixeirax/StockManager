using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

using StockManager.Src.Data.Configurations;
using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data
{
    public class DatabaseContext : DbContext
    {
        // Need to keep a contructor without parameters for "Add/Remove-Migration"
        public DatabaseContext() { }

        // Run the migrations when the DB is instantiated
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
          : base(options)
        {
            Database.Migrate();
        }

        /// <summary>
        /// Add Database Tables Here..
        /// </summary>
        public DbSet<AppSettings> AppSettings { get; set; }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<ProductLocation> ProductLocations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Auto fill the CreatedAt and the UpdatedAt model fields https://www.entityframeworktutorial.net/faq/set-created-and-modified-date-in-efcore.aspx
        /// </summary>
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<EntityEntry> entries = ChangeTracker
                .Entries()
                .Where(x => x.Entity is BaseEntity
                  && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (EntityEntry entityEntry in entries)
            {
                (( BaseEntity )entityEntry.Entity).UpdatedAt = DateTime.UtcNow;

                if (entityEntry.State == EntityState.Added)
                {
                    (( BaseEntity )entityEntry.Entity).CreatedAt = DateTime.UtcNow;
                }
            }

            return await base.SaveChangesAsync(true, cancellationToken);
        }

        /// <summary>
        /// Define the models relationships constraints, indexes and seed the initial data
        /// https://docs.microsoft.com/en-us/ef/core/modeling/indexes
        /// https://code-maze.com/efcore-relationships/ https://code-maze.com/migrations-and-seed-data-efcore/
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppSettingsConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new NotificationConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductLocationConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new StockMovementConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
