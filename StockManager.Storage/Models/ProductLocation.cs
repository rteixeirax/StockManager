using Microsoft.EntityFrameworkCore;
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

    [Required(ErrorMessage = "LocationId is required")]
    [ForeignKey("Location")]
    public int LocationId { get; set; }

    public virtual Product Product { get; set; }
    public virtual Location Location { get; set; }
  }

  /// <summary>
  /// Model Builder
  /// </summary>
  public static class ProductLocationModelBuilder
  {
    public static void Build(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<ProductLocation>()
        .Property(x => x.Stock)
        .HasDefaultValue(0);

      modelBuilder.Entity<ProductLocation>()
         .Property(x => x.MinStock)
         .HasDefaultValue(0);

      modelBuilder.Entity<ProductLocation>()
        .HasIndex(x => new { x.ProductId, x.LocationId })
        .IsUnique()
        .HasName("UniqueProductIdLocationIdPair");
    }
  }
}
