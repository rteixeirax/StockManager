using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Configurations
{
    public class StockMovementConfiguration : IEntityTypeConfiguration<StockMovement>
    {
        public void Configure(EntityTypeBuilder<StockMovement> builder)
        {
            builder
               .Property(x => x.FromLocationName)
               .HasDefaultValue(null);

            builder
               .Property(x => x.ToLocationName)
               .HasDefaultValue(null);
        }
    }
}
