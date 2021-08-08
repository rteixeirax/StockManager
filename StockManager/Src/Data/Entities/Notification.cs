namespace StockManager.Src.Data.Entities
{
    public class Notification : BaseEntity
    {
        public int NotificationId { get; set; }

        public ProductLocation ProductLocation { get; set; }
        public int ProductLocationId { get; set; }
    }
}
