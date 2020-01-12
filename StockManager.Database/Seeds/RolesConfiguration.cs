using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockManager.Database.Models;
using System;

namespace StockManager.Database.Seeds
{
  public class RolesConfiguration : IEntityTypeConfiguration<Role>
  {
    public void Configure(EntityTypeBuilder<Role> builder)
    {
      builder.HasData(
        new Role
        {
          RoleId = 1,
          Code = "Admin",
          CreatedAt = DateTime.UtcNow
        },
        new Role
        {
          RoleId = 2,
          Code = "User",
          CreatedAt = DateTime.UtcNow
        }
      );
    }
  }
}
