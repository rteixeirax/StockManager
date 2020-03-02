using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Storage.Models
{
  public class Location : BaseEntity
  {
    [Key]
    public int LocationId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
  }

  public class LocationConfiguration : IEntityTypeConfiguration<Location>
  {
    public void Configure(EntityTypeBuilder<Location> builder)
    {
      builder
        .HasIndex(x => x.Name)
        .IsUnique()
        .HasName("UniqueName");
    }
  }
}
