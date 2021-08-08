namespace StockManager.Src.Data.Entities
{
    public class StockMovement : BaseEntity
    {
        public Location FromLocation { get; set; }
        public int? FromLocationId { get; set; }
        public string FromLocationName { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public float Qty { get; set; }
        public float Stock { get; set; }
        public int StockMovementId { get; set; }
        public Location ToLocation { get; set; }
        public int? ToLocationId { get; set; }
        public string ToLocationName { get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }
    }
}
