using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Database.Source.Models
{
  public class Location : BaseEntity
  {
    [Key]
    public int LocationId { get; set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    public bool IsMain { get; set; }

    public ICollection<ProductLocation> ProductLocations { get; set; }

    public ICollection<StockMovement> StockMovementsFrom { get; set; }

    public ICollection<StockMovement> StockMovementsTo { get; set; }

  }

  public class LocationConfiguration : IEntityTypeConfiguration<Location>
  {
    public void Configure(EntityTypeBuilder<Location> builder)
    {
      builder
        .HasIndex(x => x.Name)
        .IsUnique()
        .HasName("UniqueName");

      builder
         .Property(x => x.IsMain)
         .HasDefaultValue(false);

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
       new Location {
         LocationId = 1,
         Name = "Warehouse",
         IsMain = true,
         CreatedAt = DateTime.UtcNow,
         UpdatedAt = DateTime.UtcNow
       },
       new Location {
         LocationId = 2,
         Name = "Vehicle #1",
         CreatedAt = DateTime.UtcNow,
         UpdatedAt = DateTime.UtcNow
       }
     );
    }
  }
}
