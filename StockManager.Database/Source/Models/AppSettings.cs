using System.ComponentModel.DataAnnotations;

namespace StockManager.Database.Source.Models
{
  public class AppSettings : BaseEntity
  {
    [Key]
    public int AppSettingsId { get; set; }
    public string Language { get; set; }
  }
}
