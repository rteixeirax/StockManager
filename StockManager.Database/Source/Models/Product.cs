using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Database.Source.Models
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

    // This field is used to save the product total stock that is
    // caculated in the product service.
    // The product stock is the sum of the stocks in the ProductLocation associations.
    [NotMapped]
    public float? Stock { get; set; }
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
