using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockManager.Database.Source.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockManager.Database.Source.Configurations
{
  public class ProductConfiguration : IEntityTypeConfiguration<Product>
  {
    public void Configure(EntityTypeBuilder<Product> builder)
    {
      builder
        .HasIndex(x => x.Reference)
        .IsUnique()
        .HasName("UniqueReference");

      builder
        .HasMany(x => x.ProductLocations)
        .WithOne(x => x.Product)
        .HasForeignKey(x => x.ProductId)
        .OnDelete(DeleteBehavior.Cascade);

      builder
        .HasMany(x => x.StockMovements)
        .WithOne(x => x.Product)
        .HasForeignKey(x => x.ProductId)
        .OnDelete(DeleteBehavior.Cascade);
    }
  }
}
