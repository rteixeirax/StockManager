using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Storage.Models
{
  public class Product : BaseEntity
  {
    [Key]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Reference is required")]
    public string Reference { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    public ICollection<ProductLocation> ProductLocations { get; set; }

    public ICollection<StockMovement> StockMovements { get; set; }
  }

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
