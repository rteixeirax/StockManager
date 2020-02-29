using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockManager.Storage.Models;
using System;

namespace StockManager.Storage.Seeds
{
  public class UsersConfiguration : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder.HasData(
        new User
        {
          UserId = 1,
          Username = "Admin",
          Password = BCrypt.Net.BCrypt.HashPassword("admin"),
          RoleId = 1,
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        }
      );
    }
  }
}
