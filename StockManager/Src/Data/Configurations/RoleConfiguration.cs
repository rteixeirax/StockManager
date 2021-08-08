﻿using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder
                .HasKey(x => x.RoleId);

            builder
                .Property(x => x.Code)
                .IsRequired();

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
              new Role
              {
                  RoleId = 1,
                  Code = "Admin",
                  CreatedAt = DateTime.UtcNow,
                  UpdatedAt = DateTime.UtcNow
              },
              new Role
              {
                  RoleId = 2,
                  Code = "User",
                  CreatedAt = DateTime.UtcNow,
                  UpdatedAt = DateTime.UtcNow
              }
            );
        }
    }
}
