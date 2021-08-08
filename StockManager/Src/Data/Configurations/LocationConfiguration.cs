﻿using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder
                .HasKey(x => x.LocationId);

            builder
                .Property(x => x.Name)
                .IsRequired();

            builder
              .Property(x => x.IsMain)
              .HasDefaultValue(false);

            builder
                .HasIndex(x => x.Name)
                .IsUnique()
                .HasName("UniqueName");

            builder
                .HasIndex(x => x.IsMain)
                .HasName("IsMainIndex");

            builder
                .HasMany(x => x.ProductLocations)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.StockMovementsFrom)
                .WithOne(x => x.FromLocation)
                .HasForeignKey(x => x.FromLocationId)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasMany(x => x.StockMovementsTo)
                .WithOne(x => x.ToLocation)
                .HasForeignKey(x => x.ToLocationId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasData(
             new Location
             {
                 LocationId = 1,
                 Name = "Warehouse",
                 IsMain = true,
                 CreatedAt = DateTime.UtcNow,
                 UpdatedAt = DateTime.UtcNow
             },
             new Location
             {
                 LocationId = 2,
                 Name = "Vehicle #1",
                 CreatedAt = DateTime.UtcNow,
                 UpdatedAt = DateTime.UtcNow
             }
           );
        }
    }
}
