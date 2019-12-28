using Microsoft.EntityFrameworkCore;
using StockManager.Database.Models;

namespace StockManager.Database
{
  public class AppDbContext : DbContext
  {
    /* 
     * ## How to set the Database connection ##
     * 
     * 1. Go to your .db file and add it to the solution. 
     * (In this case i added the "AppData" folder with the file inside)
     * 2. Right click on it and go to properties.
     * 3. Set the Build Action to content.
     * 4. Set the Copy to Output Directory to copy always.
     * 
     * With this changes, your DB file will always be copied to your /bin/debug directory,
     * otherwise when you start the project you will get the "table not found" error.
     * 
     * ## Usefull commands ##   
     * 
     * 1. Add-Migration MIGRATION_NAME => Create a migration   
     * 2. Update-Database => Update the DB with the last changes   
     * 3. Remove-Migration => Undo the migration
     */

    public AppDbContext() : base() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      // TODO:
      // Find how to get the connectionString from the App.config
      // And how to set the DB auth. (if possible)

      base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseSqlite(@"Data Source=.\AppData\StockManagerDB.db");
    }

    // Add Database Tables Here..    
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
  }
}
