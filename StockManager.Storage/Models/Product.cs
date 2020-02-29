using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Database.Models
{
  public class Product : BaseEntity
  {
    [Key]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Reference is required")]
    public string Reference { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
  }

  /// <summary>
  /// Model Builder
  /// </summary>
  public static class ProductModelBuilder
  {
    public static void Build(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Product>()
          .HasIndex(x => x.Reference)
          .IsUnique()
          .HasName("UniqueReference");
    }
  }
}
