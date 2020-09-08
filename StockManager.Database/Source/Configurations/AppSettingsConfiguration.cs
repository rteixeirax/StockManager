using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StockManager.Core.Source.Models;

namespace StockManager.Database.Source.Configurations
{
    internal class AppSettingsConfiguration : IEntityTypeConfiguration<AppSettings>
    {
        public void Configure(EntityTypeBuilder<AppSettings> builder)
        {
            builder
                .HasKey(x => x.AppSettingsId);

            builder
                .Property(x => x.DefaultGlobalMinStock)
                .HasDefaultValue(0);

            builder.HasData(new AppSettings
            {
                AppSettingsId = 1,
                Language = "pt-PT",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
        }
    }
}
