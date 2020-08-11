namespace StockManager.Core.Source.Models
{
    public class Notification : BaseEntity
    {
        public int NotificationId { get; set; }

        public int ProductLocationId { get; set; }

        public ProductLocation ProductLocation { get; set; }
    }
}
