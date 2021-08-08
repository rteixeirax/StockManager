using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder
                .HasKey(x => x.NotificationId);

            builder
                .Property(x => x.ProductLocationId)
                .IsRequired();
        }
    }
}
