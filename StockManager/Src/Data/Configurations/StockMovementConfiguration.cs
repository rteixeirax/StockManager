using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Configurations
{
    public class StockMovementConfiguration : IEntityTypeConfiguration<StockMovement>
    {
        public void Configure(EntityTypeBuilder<StockMovement> builder)
        {
            builder
                .HasKey(x => x.StockMovementId);

            builder
                .Property(x => x.Qty)
                .IsRequired();

            builder
                .Property(x => x.Stock)
                .IsRequired();

            builder
                .Property(x => x.ProductId)
                .IsRequired();

            builder
               .Property(x => x.FromLocationName)
               .HasDefaultValue(null);

            builder
               .Property(x => x.ToLocationName)
               .HasDefaultValue(null);
        }
    }
}
