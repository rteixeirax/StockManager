using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StockManager.Core.Source.Models;

namespace StockManager.Database.Source.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(x => x.UserId);

            builder
                .Property(x => x.Username)
                .IsRequired();

            builder
                .Property(x => x.Password)
                .IsRequired();

            builder
                .Property(x => x.RoleId)
                .IsRequired();

            builder
                .HasIndex(x => x.Username)
                .IsUnique()
                .HasName("UniqueUsername");

            builder
                .HasMany(x => x.StockMovements)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.SetNull);

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
