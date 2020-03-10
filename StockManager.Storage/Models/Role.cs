using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Storage.Models {
  public class Role : BaseEntity {
    [Key]
    public int RoleId { get; set; }

    [Required(ErrorMessage = "Code is required")]
    public string Code { get; set; }

    public ICollection<User> Users { get; set; }
  }

  public class RoleConfiguration : IEntityTypeConfiguration<Role> {
    public void Configure(EntityTypeBuilder<Role> builder) {
      builder
        .HasIndex(x => x.Code)
        .IsUnique()
        .HasName("UniqueCode");

      builder
        .HasMany(x => x.Users)
        .WithOne(x => x.Role)
        .HasForeignKey(x => x.RoleId)
        .OnDelete(DeleteBehavior.Restrict);

      builder.HasData(
        new Role {
          RoleId = 1,
          Code = "Admin",
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        },
        new Role {
          RoleId = 2,
          Code = "User",
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        }
      );
    }
  }
}
