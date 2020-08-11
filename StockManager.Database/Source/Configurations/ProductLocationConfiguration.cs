using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StockManager.Core.Source.Models;

namespace StockManager.Database.Source.Configurations
{
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

            builder
                .HasMany(x => x.Notifications)
                .WithOne(x => x.ProductLocation)
                .HasForeignKey(x => x.ProductLocationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
