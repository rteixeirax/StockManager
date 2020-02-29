using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Database.Models
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

    public virtual Role Role { get; set; }
  }

  /// <summary>
  /// Model Builder
  /// </summary>
  public static class UserModelBuilder
  {
    public static void Build(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>()
          .HasIndex(x => x.Username)
          .IsUnique()
          .HasName("UniqueUsername");
    }
  }
}
