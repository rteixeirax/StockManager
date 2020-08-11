namespace StockManager.Core.Source.Models
{
    public class AppSettings : BaseEntity
    {
        public int AppSettingsId { get; set; }

        public string Language { get; set; }
    }
}
