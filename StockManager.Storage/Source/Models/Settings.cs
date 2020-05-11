using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace StockManager.Storage.Source.Models {
  public class Settings : BaseEntity {
    [Key]
    public int SettingsId { get; set; }
    public string Language { get; set; }
  }

  public class SettingsConfiguration : IEntityTypeConfiguration<Settings> {
    public void Configure(EntityTypeBuilder<Settings> builder) {
      builder.HasData(
       new Settings {
         SettingsId = 1,
         Language = "pt-PT",
         CreatedAt = DateTime.UtcNow,
         UpdatedAt = DateTime.UtcNow
       }
     );
    }
  }
}
