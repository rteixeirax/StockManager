using System;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using StockManager.Core.Source;
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
                DocumentsFolder = AppConstants.DocumentsFolders.ElementAt(0).Code,
                Language = AppConstants.AppLanguages.ElementAt(0).Code,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
        }
    }
}
