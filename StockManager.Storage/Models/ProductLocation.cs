using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManager.Storage.Models
{
  public class ProductLocation : BaseEntity
  {
    [Key]
    public int ProductLocationId { get; set; }

    public float Stock { get; set; }

    public float MinStock { get; set; }

    [Required(ErrorMessage = "ProductId is required")]
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }

    [Required(ErrorMessage = "LocationId is required")]
    [ForeignKey("Location")]
    public int LocationId { get; set; }
    public Location Location { get; set; }
  }

  public class ProductLocationConfiguration : IEntityTypeConfiguration<ProductLocation>
  {
    public void Configure(EntityTypeBuilder<ProductLocation> builder)
    {
      builder
        .Property(x => x.Stock)
        .HasDefaultValue(0);

      builder
        .Property(x => x.MinStock)
       .HasDefaultValue(0);

      builder
        .HasIndex(x => new { x.ProductId, x.LocationId })
        .IsUnique()
        .HasName("UniqueProductIdLocationIdPair");
    }
  }
}
