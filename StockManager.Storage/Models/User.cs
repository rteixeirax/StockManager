using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Storage.Models
{
  public class User : BaseEntity
  {
    [Key]
    public int UserId { get; set; }

    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }

    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }

    // Allow null
    public DateTime? LastLogin { get; set; }

    [ForeignKey("Role")]
    public int RoleId { get; set; }

    public Role Role { get; set; }
  }

  public class UserConfiguration : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder
        .HasIndex(x => x.Username)
        .IsUnique()
        .HasName("UniqueUsername");

      // Initial data
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
