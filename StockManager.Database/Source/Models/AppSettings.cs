using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Database.Source.Models
{
  public class AppSettings : BaseEntity
  {
    [Key]
    public int AppSettingsId { get; set; }
    public string Language { get; set; }
  }

  public class SettingsConfiguration : IEntityTypeConfiguration<AppSettings>
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
