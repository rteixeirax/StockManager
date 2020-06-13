using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockManager.Database.Source.Models;
using System;

namespace StockManager.Database.Source.Configurations
{
  class AppSettingsConfiguration : IEntityTypeConfiguration<AppSettings>
  {
    public void Configure(EntityTypeBuilder<AppSettings> builder)
    {
      builder.HasData(
       new AppSettings {
         AppSettingsId = 1,
         Language = "pt-PT",
         CreatedAt = DateTime.UtcNow,
         UpdatedAt = DateTime.UtcNow
       }
     );
    }
  }
}
