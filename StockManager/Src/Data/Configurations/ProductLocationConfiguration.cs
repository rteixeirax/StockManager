using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Configurations
{
    public class ProductLocationConfiguration : IEntityTypeConfiguration<ProductLocation>
    {
        public void Configure(EntityTypeBuilder<ProductLocation> builder)
        {
            builder
                .HasKey(x => x.ProductLocationId);

            builder
                .Property(x => x.LocationId)
                .IsRequired();

            builder
                .Property(x => x.ProductId)
                .IsRequired();

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

            //builder
            //    .HasMany(x => x.Notifications)
            //    .WithOne(x => x.ProductLocation)
            //    .HasForeignKey(x => x.ProductLocationId)
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
