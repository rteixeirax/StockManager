namespace StockManager.Src.Data.Entities
{
    public class AppSettings : BaseEntity
    {
        public int AppSettingsId { get; set; }

        public float DefaultGlobalMinStock { get; set; }
        public string DocumentsFolder { get; set; }

        public string Language { get; set; }
    }
}
