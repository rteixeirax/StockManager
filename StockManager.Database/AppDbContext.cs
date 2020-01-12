using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StockManager.Database.Models;
using StockManager.Database.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockManager.Database
{
  public class AppDbContext : DbContext
  {
    public AppDbContext() : base() { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseSqlite(@"Data Source=.\StockManagerDB.sqlite");
    }

    /*
     * Auto fill the CreatedAt and the UpdatedAt model fields
     * https://www.entityframeworktutorial.net/faq/set-created-and-modified-date-in-efcore.aspx
     */
    public override int SaveChanges()
    {
      IEnumerable<EntityEntry> entries = ChangeTracker
          .Entries()
          .Where(x => x.Entity is BaseEntity
            && (x.State == EntityState.Added || x.State == EntityState.Modified));

      foreach (EntityEntry entityEntry in entries)
      {
        ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTime.UtcNow;

        if (entityEntry.State == EntityState.Added)
        {
          ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.UtcNow;
        }
      }

      return base.SaveChanges();
    }

    /*
     * Add models indexes and seed the inital DB values
     * https://docs.microsoft.com/en-us/ef/core/modeling/indexes
     */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Role>()
          .HasIndex(x => x.Code)
          .IsUnique()
          .HasName("UniqueCode");

      modelBuilder.Entity<User>()
          .HasIndex(x => x.Username)
          .IsUnique()
          .HasName("UniqueUsername");

      // Seed the DB with the initial values
      // https://code-maze.com/migrations-and-seed-data-efcore/
      modelBuilder.ApplyConfiguration(new RolesConfiguration());
      modelBuilder.ApplyConfiguration(new UsersConfiguration());
    }


    /* Add Database Tables Here.. */
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
  }
}
