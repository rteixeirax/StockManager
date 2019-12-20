using Microsoft.EntityFrameworkCore;
using StockManager.Database.Models;

namespace StockManager.Database
{
  public class AppDbContext : DbContext
  {
    // Usefull commands:   
    // -> Add-Migration MIGRATION_NAME => Create a migration   
    // -> Update-Database => Update the DB with the last changes   
    // -> Remove-Migration => Undo the migration

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite(@"Data Source=.\StockManagerDB.db");

    // DATABASE TABLES HERE..    
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
  }
}
